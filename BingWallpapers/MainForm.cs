using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
  更新日志:

  * 1.2.151221
	修复CN必应图片标题获取

*/

namespace BingWallpapers
{
	public partial class MainForm : Form
	{
		private ResourceManager res;

        public MainForm()
		{
			InitializeComponent();
			res = new ResourceManager("BingWallpapers.strings", typeof(MainForm).Assembly);
            warningTooltip.ToolTipTitle = res.GetString("warningTooltip_ToolTipTitle");
			infoTooltip.ToolTipTitle = res.GetString("infoTooltip_ToolTipTitle");
        }

		private const int CP_NOCLOSE_BUTTON = 0x200;

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams myCp = base.CreateParams;
				myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
				return myCp;
			}
		}

		private bool bAutoRun = true;
		private bool bUpdateAll = true;
		private bool bAutoExit = true;
		private bool bSaveAll = true;
		private int dwTrimTemp = 20;

		private void loadSettings()
		{
			bAutoRun = Settings.AutoRun;
			bUpdateAll = Settings.UpdateAll;
			bAutoExit = Settings.AutoExit;
			bSaveAll = Settings.SaveAll;
		}

		private const int ZH_CN = 0;
		private const int EN_US = 1;
		private const int ES_ES = 2;
		private const int FR_FR = 3;
		private const int EN_GB = 4;
		private const int TOTAL = EN_GB + 1;

		private string[] strLocale = {
			"ZH-CN",
			"EN-US",
			"ES-ES",
			"FR-FR",
			"EN-GB"
		};

		private void initTimeLabels()
		{
			timeLabels.Add(ltZhcn);
			timeLabels.Add(ltEnus);
			timeLabels.Add(ltEses);
			timeLabels.Add(ltFrfr);
			timeLabels.Add(ltEngb);
		}

		private void initPics()
		{
			pics.Add(picZHCN);
			pics.Add(picENUS);
			pics.Add(picESES);
			pics.Add(picFRFR);
			pics.Add(picENGB);
		}

		private void initRefreshLabels()
		{
			refreshLabels.Add(refreshZhcn);
			refreshLabels.Add(refreshEnus);
			refreshLabels.Add(refreshEses);
			refreshLabels.Add(refreshFrfr);
			refreshLabels.Add(refreshEngb);
		}

		private void initSaveList()
		{
			saveList.Add(chkZhcn);
			saveList.Add(chkEnus);
			saveList.Add(chkEses);
			saveList.Add(chkFrfr);
			saveList.Add(chkEngb);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			loadSettings();

			chkAutoRun.Checked = bAutoRun;
			chkAutoExit.Checked = bAutoExit;

			if (bUpdateAll)
				rdUpdateAll.Checked = true;
			else
				rdUpdateTwo.Checked = true;

			if (bSaveAll)
				rdSaveAll.Checked = true;
			else
				rdSaveOne.Checked = true;

			initTimeLabels();
			initPics();
			initRefreshLabels();
			initSaveList();

			for (int i = 0; i < TOTAL; i++)
				timeLabels[i].Text = getTodayDateString(strLocale[i]);

			bStopWorker = false;
			updateIndexOnly = -1;

			updateWorker = new Thread(new ThreadStart(updateWorkerThread));
			updateWorker.Start();
		}

		private List<Label> timeLabels = new List<Label>();
		private List<PictureBox> pics = new List<PictureBox>();
		private List<Label> refreshLabels = new List<Label>();
		private List<CheckBox> saveList = new List<CheckBox>();
		private string[] strPicTempPath = new string[TOTAL];
		private bool[] bPictureDownloaded = { false, false, false, false, false };
		private bool bWallpaperApplied = false;

		private static string appPath = AppDomain.CurrentDomain.BaseDirectory;
		private string cachePath = appPath + @"Pictures\";
		private string tempPath = appPath + @"temp\";

		private Thread updateWorker = null;
		private bool bStopWorker = false;
		private int updateIndexOnly = -1;

		private string getTodayDateString(string locale)
		{
			DateTime now = DateTime.UtcNow;
			TimeZoneInfo zone = null;

			if (locale.Equals("ZH-CN"))
				zone = TimeZoneInfo.FindSystemTimeZoneById("China Standard Time"); //(GMT+08:00) Beijing, Chongqing, Hong Kong, Urumqi
			else if (locale.Equals("EN-US"))
				zone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");//(GMT-06:00) Central Time (US & Canada) Central Standard Time
																					// GMT-7 PST
			else if (locale.Equals("ES-ES"))
				zone = TimeZoneInfo.FindSystemTimeZoneById("Romance Standard Time");//(GMT+01:00) Brussels, Copenhagen, Madrid, Paris
			else if (locale.Equals("FR-FR"))
				zone = TimeZoneInfo.FindSystemTimeZoneById("Romance Standard Time");//(GMT+01:00) Brussels, Copenhagen, Madrid, Paris
			else if (locale.Equals("EN-GB"))
				zone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");//(GMT) Greenwich Mean Time : Dublin, Edinburgh, Lisbon, London</option>

			DateTime converted = TimeZoneInfo.ConvertTimeFromUtc(now, zone);
			return converted.ToString("yyyy-MM-dd");
		}

		private void updateWorkerThread()
		{
			while (!Settings.AutoExit)
				Thread.Sleep(TimeSpan.FromSeconds(10.0));

			loadSettings();
			bWallpaperApplied = false;

			BingImage bing = new BingImage(356, cachePath);

			updateNotifyIconText("Bing每日壁纸（正在更新今日壁纸）");

			for (int i = 0; i < TOTAL; i++)
			{
				if (bStopWorker)
					break;

				if (updateIndexOnly != -1 && i != updateIndexOnly)
					continue;

				updateDateLabel(i, getTodayDateString(strLocale[i]));

				if (updateIndexOnly == -1 && !bUpdateAll && i >= 2)
				{
					continue;
				}

				try
				{
					bPictureDownloaded[i] = false;
					strPicTempPath[i] = Path.Combine(this.tempPath,
						getTodayDateString(strLocale[i]) + "-" + strLocale[i] + ".jpg");

					if (!File.Exists(strPicTempPath[i]))
					{
						//try to download
						ImageInfo info = bing.getTodayImageInfo(strLocale[i]);
						if (info != null)
						{
							BingImage.DownloadFile(info.url, strPicTempPath[i]);
							Settings.Title(strLocale[i], info.title);
							Settings.Copyright(strLocale[i], info.copyright);
						}
					}

					if (File.Exists(strPicTempPath[i]))
					{
						bPictureDownloaded[i] = true;
						showRefreshButton(false, i);
						pics[i].Invoke(new MethodInvoker(
							() =>
							{
								string caption = "点击设置为壁纸";
								string captionTemp;
								string picTitle = Settings.Title(strLocale[i]);
								
								if (!String.IsNullOrEmpty(picTitle))
								{
									captionTemp = picTitle;

									string picCopyright = Settings.Copyright(strLocale[i]);
									if (picCopyright != "")
										captionTemp += (" " + picCopyright);

									caption = captionTemp + Environment.NewLine + Environment.NewLine + caption;
								}

                                infoTooltip.SetToolTip(pics[i], caption);

								pics[i].Image = Image.FromFile(strPicTempPath[i]);
							}));
					}
					else
					{
						updateNotifyIconText("Bing每日壁纸（网络异常，请稍后重试）");
						showRefreshButton(true, i);
					}
				}
				catch
				{
					updateNotifyIconText("Bing每日壁纸（网络异常，请稍后重试）");
					showRefreshButton(true, i);
				}

				Thread.Sleep(TimeSpan.FromSeconds(1.0));
			}

			bing.trimTemp(this.tempPath, dwTrimTemp);
		}

		private void updateNotifyIconText(string str)
		{
			this.Invoke(
				new MethodInvoker(
					delegate
					{
						notifyIcon.Text = str;
					}
				)
			);
		}

		private void showRefreshButton(bool bShow, int index)
		{
			this.Invoke(new MethodInvoker(
				() =>
				{
					refreshLabels[index].Visible = bShow;
				}
			));
		}

		private void updateDateLabel(int index, string dateStr)
		{
			this.Invoke(new MethodInvoker(
				() =>
				{
					timeLabels[index].Text = dateStr;
				}
			));
		}

		private bool bAppExitExecuted = false;
		private void AppExit()
		{
			if (bAppExitExecuted)
				return;

			Settings.AutoRun = chkAutoRun.Checked;
			Settings.AutoExit = chkAutoExit.Checked;
			Settings.UpdateAll = (rdUpdateAll.Checked) ? true : false;
			Settings.SaveAll = (rdSaveAll.Checked) ? true : false;

			bStopWorker = true;
			this.notifyIcon.Visible = false;

			Directory.CreateDirectory(Path.GetDirectoryName(cachePath));

			//Save
			if (Settings.SaveAll)
			{
				for (int i = 0; i < TOTAL; i++)
				{
					if (File.Exists(strPicTempPath[i]))
					{
						string path = Path.GetFileName(strPicTempPath[i]);
						path = Path.Combine(cachePath, path);
						if (!File.Exists(path))
							File.Copy(strPicTempPath[i], path);
					}
				}
			}
			else
			{
				for (int i = 0; i < TOTAL; i++)
				{
					if (saveList[i].Checked)
					{
						if (File.Exists(strPicTempPath[i]))
						{
							string path = Path.GetFileName(strPicTempPath[i]);
							path = Path.Combine(cachePath, path);
							if (!File.Exists(path))
								File.Copy(strPicTempPath[i], path);
						}
					}
				}
			}

			bAppExitExecuted = true;
			Application.Exit();
		}

		private void picBoxClick(int index)
		{
			if (bPictureDownloaded[index])
			{
				bool bSucc = BingImage.setWallpaper(strPicTempPath[index]);
				if (bSucc)
				{
					bWallpaperApplied = true;
				}
				else
				{
					bWallpaperApplied = false;
					MessageBox.Show("!!!>:( \n只支持Win7以上操作系统！", "Bing每日壁纸", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				this.notifyIcon.Text = "Bing每日壁纸";
			}

			if (Settings.AutoExit && bWallpaperApplied)
				this.Close();
		}

		private void picZHCN_Click(object sender, EventArgs e)
		{
			picBoxClick(ZH_CN);
		}

		private void picENUS_Click(object sender, EventArgs e)
		{
			picBoxClick(EN_US);
		}

		private void picESES_Click(object sender, EventArgs e)
		{
			picBoxClick(ES_ES);
		}

		private void picFRFR_Click(object sender, EventArgs e)
		{
			picBoxClick(FR_FR);
		}

		private void picENGB_Click(object sender, EventArgs e)
		{
			picBoxClick(EN_GB);
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.AppExit();
		}

		private void chkAutoExit_CheckedChanged(object sender, EventArgs e)
		{
			Settings.AutoExit = chkAutoExit.Checked;
		}

		private void chkAutoRun_CheckedChanged(object sender, EventArgs e)
		{
			Settings.AutoRun = chkAutoRun.Checked;
		}

		private void rdUpdateTwo_CheckedChanged(object sender, EventArgs e)
		{
			Settings.UpdateAll = (rdUpdateTwo.Checked) ? false : true;
		}

		private void rdUpdateAll_CheckedChanged(object sender, EventArgs e)
		{
			Settings.UpdateAll = (rdUpdateAll.Checked) ? true : false;
		}

		private void rdSaveAll_CheckedChanged(object sender, EventArgs e)
		{
			Settings.SaveAll = (rdSaveAll.Checked) ? true : false;
		}

		private void rdSaveOne_CheckedChanged(object sender, EventArgs e)
		{
			Settings.SaveAll = (rdSaveOne.Checked) ? false : true;
		}

		private void refreshLabelClick(int index)
		{
			refreshLabels[index].Visible = false;
			pics[index].Image = null;
			updateIndexOnly = index;
			bStopWorker = false;

			updateWorker = new Thread(new ThreadStart(updateWorkerThread));
			updateWorker.Start();
		}

		private void refreshZhcn_Click(object sender, EventArgs e)
		{
			refreshLabelClick(ZH_CN);
		}

		private void refreshEnus_Click(object sender, EventArgs e)
		{
			refreshLabelClick(EN_US);
		}

		private void refreshEses_Click(object sender, EventArgs e)
		{
			refreshLabelClick(ES_ES);
		}

		private void refreshFrfr_Click(object sender, EventArgs e)
		{
			refreshLabelClick(FR_FR);
		}

		private void refreshEngb_Click(object sender, EventArgs e)
		{
			refreshLabelClick(EN_GB);
		}

		private void btnDirectExit_Click(object sender, EventArgs e)
		{
			bAppExitExecuted = true;
			Application.Exit();
		}

		private void infoTooltip_Popup(object sender, PopupEventArgs e)
		{
			if (e.AssociatedControl.GetType() == typeof(PictureBox))
			{
				var tmp = e.AssociatedControl as PictureBox;
				if (tmp.Image == null)
					e.Cancel = true;
			}
			else if (e.AssociatedControl.GetType() == typeof(CheckBox))
			{
				var tmp = e.AssociatedControl as CheckBox;
				if (tmp.Tag != null)
				{
					int index = Convert.ToInt32(tmp.Tag);
					if (index < TOTAL)
					{
						if (pics[index].Image == null)
							e.Cancel = true;
					}
				}
			}
		}

		private void btnDirectExit_MouseEnter(object sender, EventArgs e)
		{
			btnDirectExit.BackColor = Color.LemonChiffon;
		}

		private void btnDirectExit_MouseLeave(object sender, EventArgs e)
		{
			btnDirectExit.BackColor = Color.White;
		}

		private void descTooltip_Draw(object sender, DrawToolTipEventArgs e)
		{
			e.Graphics.DrawImage(imageList.Images[2], e.Bounds);
		}

	}
}
