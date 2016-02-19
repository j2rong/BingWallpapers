namespace BingWallpapers
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.chkAutoExit = new System.Windows.Forms.CheckBox();
			this.picZHCN = new System.Windows.Forms.PictureBox();
			this.labelZHCN = new System.Windows.Forms.Label();
			this.labelCustom = new System.Windows.Forms.Label();
			this.picENUS = new System.Windows.Forms.PictureBox();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.ltZhcn = new System.Windows.Forms.Label();
			this.ltEnus = new System.Windows.Forms.Label();
			this.chkAutoRun = new System.Windows.Forms.CheckBox();
			this.rdSaveAll = new System.Windows.Forms.RadioButton();
			this.rdSaveOne = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.ltEses = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.picESES = new System.Windows.Forms.PictureBox();
			this.ltFrfr = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.picFRFR = new System.Windows.Forms.PictureBox();
			this.ltEngb = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.picENGB = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rdUpdateAll = new System.Windows.Forms.RadioButton();
			this.rdUpdateTwo = new System.Windows.Forms.RadioButton();
			this.refreshZhcn = new System.Windows.Forms.Label();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.refreshEnus = new System.Windows.Forms.Label();
			this.refreshEses = new System.Windows.Forms.Label();
			this.refreshFrfr = new System.Windows.Forms.Label();
			this.refreshEngb = new System.Windows.Forms.Label();
			this.chkZhcn = new System.Windows.Forms.CheckBox();
			this.chkEnus = new System.Windows.Forms.CheckBox();
			this.chkEses = new System.Windows.Forms.CheckBox();
			this.chkFrfr = new System.Windows.Forms.CheckBox();
			this.chkEngb = new System.Windows.Forms.CheckBox();
			this.btnDirectExit = new System.Windows.Forms.Button();
			this.warningTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.picBanner = new System.Windows.Forms.PictureBox();
			this.infoTooltip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.picZHCN)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picENUS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picESES)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFRFR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picENGB)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
			this.SuspendLayout();
			// 
			// chkAutoExit
			// 
			resources.ApplyResources(this.chkAutoExit, "chkAutoExit");
			this.chkAutoExit.Checked = true;
			this.chkAutoExit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAutoExit.Name = "chkAutoExit";
			this.chkAutoExit.UseVisualStyleBackColor = true;
			this.chkAutoExit.CheckedChanged += new System.EventHandler(this.chkAutoExit_CheckedChanged);
			// 
			// picZHCN
			// 
			resources.ApplyResources(this.picZHCN, "picZHCN");
			this.picZHCN.Name = "picZHCN";
			this.picZHCN.TabStop = false;
			this.warningTooltip.SetToolTip(this.picZHCN, resources.GetString("picZHCN.ToolTip"));
			this.picZHCN.Click += new System.EventHandler(this.picZHCN_Click);
			// 
			// labelZHCN
			// 
			resources.ApplyResources(this.labelZHCN, "labelZHCN");
			this.labelZHCN.BackColor = System.Drawing.Color.CornflowerBlue;
			this.labelZHCN.ForeColor = System.Drawing.Color.White;
			this.labelZHCN.Name = "labelZHCN";
			// 
			// labelCustom
			// 
			resources.ApplyResources(this.labelCustom, "labelCustom");
			this.labelCustom.BackColor = System.Drawing.Color.CornflowerBlue;
			this.labelCustom.ForeColor = System.Drawing.Color.White;
			this.labelCustom.Name = "labelCustom";
			// 
			// picENUS
			// 
			resources.ApplyResources(this.picENUS, "picENUS");
			this.picENUS.Name = "picENUS";
			this.picENUS.TabStop = false;
			this.warningTooltip.SetToolTip(this.picENUS, resources.GetString("picENUS.ToolTip"));
			this.picENUS.Click += new System.EventHandler(this.picENUS_Click);
			// 
			// notifyIcon
			// 
			resources.ApplyResources(this.notifyIcon, "notifyIcon");
			// 
			// ltZhcn
			// 
			resources.ApplyResources(this.ltZhcn, "ltZhcn");
			this.ltZhcn.Name = "ltZhcn";
			// 
			// ltEnus
			// 
			resources.ApplyResources(this.ltEnus, "ltEnus");
			this.ltEnus.Name = "ltEnus";
			// 
			// chkAutoRun
			// 
			resources.ApplyResources(this.chkAutoRun, "chkAutoRun");
			this.chkAutoRun.Checked = true;
			this.chkAutoRun.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAutoRun.Name = "chkAutoRun";
			this.chkAutoRun.UseVisualStyleBackColor = true;
			this.chkAutoRun.CheckedChanged += new System.EventHandler(this.chkAutoRun_CheckedChanged);
			// 
			// rdSaveAll
			// 
			resources.ApplyResources(this.rdSaveAll, "rdSaveAll");
			this.rdSaveAll.Checked = true;
			this.rdSaveAll.Name = "rdSaveAll";
			this.rdSaveAll.TabStop = true;
			this.rdSaveAll.UseVisualStyleBackColor = true;
			this.rdSaveAll.CheckedChanged += new System.EventHandler(this.rdSaveAll_CheckedChanged);
			// 
			// rdSaveOne
			// 
			resources.ApplyResources(this.rdSaveOne, "rdSaveOne");
			this.rdSaveOne.Name = "rdSaveOne";
			this.rdSaveOne.TabStop = true;
			this.rdSaveOne.UseVisualStyleBackColor = true;
			this.rdSaveOne.CheckedChanged += new System.EventHandler(this.rdSaveOne_CheckedChanged);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
			this.label1.Name = "label1";
			// 
			// ltEses
			// 
			resources.ApplyResources(this.ltEses, "ltEses");
			this.ltEses.Name = "ltEses";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Name = "label3";
			// 
			// picESES
			// 
			resources.ApplyResources(this.picESES, "picESES");
			this.picESES.Name = "picESES";
			this.picESES.TabStop = false;
			this.warningTooltip.SetToolTip(this.picESES, resources.GetString("picESES.ToolTip"));
			this.picESES.Click += new System.EventHandler(this.picESES_Click);
			// 
			// ltFrfr
			// 
			resources.ApplyResources(this.ltFrfr, "ltFrfr");
			this.ltFrfr.Name = "ltFrfr";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Name = "label4";
			// 
			// picFRFR
			// 
			resources.ApplyResources(this.picFRFR, "picFRFR");
			this.picFRFR.Name = "picFRFR";
			this.picFRFR.TabStop = false;
			this.warningTooltip.SetToolTip(this.picFRFR, resources.GetString("picFRFR.ToolTip"));
			this.picFRFR.Click += new System.EventHandler(this.picFRFR_Click);
			// 
			// ltEngb
			// 
			resources.ApplyResources(this.ltEngb, "ltEngb");
			this.ltEngb.Name = "ltEngb";
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Name = "label5";
			// 
			// picENGB
			// 
			resources.ApplyResources(this.picENGB, "picENGB");
			this.picENGB.Name = "picENGB";
			this.picENGB.TabStop = false;
			this.warningTooltip.SetToolTip(this.picENGB, resources.GetString("picENGB.ToolTip"));
			this.picENGB.Click += new System.EventHandler(this.picENGB_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rdSaveAll);
			this.panel1.Controls.Add(this.rdSaveOne);
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.rdUpdateAll);
			this.panel2.Controls.Add(this.rdUpdateTwo);
			resources.ApplyResources(this.panel2, "panel2");
			this.panel2.Name = "panel2";
			// 
			// rdUpdateAll
			// 
			resources.ApplyResources(this.rdUpdateAll, "rdUpdateAll");
			this.rdUpdateAll.Checked = true;
			this.rdUpdateAll.Name = "rdUpdateAll";
			this.rdUpdateAll.TabStop = true;
			this.rdUpdateAll.UseVisualStyleBackColor = true;
			this.rdUpdateAll.CheckedChanged += new System.EventHandler(this.rdUpdateAll_CheckedChanged);
			// 
			// rdUpdateTwo
			// 
			resources.ApplyResources(this.rdUpdateTwo, "rdUpdateTwo");
			this.rdUpdateTwo.Name = "rdUpdateTwo";
			this.rdUpdateTwo.UseVisualStyleBackColor = true;
			this.rdUpdateTwo.CheckedChanged += new System.EventHandler(this.rdUpdateTwo_CheckedChanged);
			// 
			// refreshZhcn
			// 
			resources.ApplyResources(this.refreshZhcn, "refreshZhcn");
			this.refreshZhcn.ImageList = this.imageList;
			this.refreshZhcn.Name = "refreshZhcn";
			this.refreshZhcn.Click += new System.EventHandler(this.refreshZhcn_Click);
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "refresh-01.ico");
			// 
			// refreshEnus
			// 
			resources.ApplyResources(this.refreshEnus, "refreshEnus");
			this.refreshEnus.ImageList = this.imageList;
			this.refreshEnus.Name = "refreshEnus";
			this.refreshEnus.Click += new System.EventHandler(this.refreshEnus_Click);
			// 
			// refreshEses
			// 
			resources.ApplyResources(this.refreshEses, "refreshEses");
			this.refreshEses.ImageList = this.imageList;
			this.refreshEses.Name = "refreshEses";
			this.refreshEses.Click += new System.EventHandler(this.refreshEses_Click);
			// 
			// refreshFrfr
			// 
			resources.ApplyResources(this.refreshFrfr, "refreshFrfr");
			this.refreshFrfr.ImageList = this.imageList;
			this.refreshFrfr.Name = "refreshFrfr";
			this.refreshFrfr.Click += new System.EventHandler(this.refreshFrfr_Click);
			// 
			// refreshEngb
			// 
			resources.ApplyResources(this.refreshEngb, "refreshEngb");
			this.refreshEngb.ImageList = this.imageList;
			this.refreshEngb.Name = "refreshEngb";
			this.refreshEngb.Click += new System.EventHandler(this.refreshEngb_Click);
			// 
			// chkZhcn
			// 
			resources.ApplyResources(this.chkZhcn, "chkZhcn");
			this.chkZhcn.Checked = true;
			this.chkZhcn.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkZhcn.Name = "chkZhcn";
			this.chkZhcn.Tag = "0";
			this.warningTooltip.SetToolTip(this.chkZhcn, resources.GetString("chkZhcn.ToolTip"));
			this.chkZhcn.UseVisualStyleBackColor = true;
			// 
			// chkEnus
			// 
			resources.ApplyResources(this.chkEnus, "chkEnus");
			this.chkEnus.Name = "chkEnus";
			this.chkEnus.Tag = "1";
			this.warningTooltip.SetToolTip(this.chkEnus, resources.GetString("chkEnus.ToolTip"));
			this.chkEnus.UseVisualStyleBackColor = true;
			// 
			// chkEses
			// 
			resources.ApplyResources(this.chkEses, "chkEses");
			this.chkEses.Name = "chkEses";
			this.chkEses.Tag = "2";
			this.warningTooltip.SetToolTip(this.chkEses, resources.GetString("chkEses.ToolTip"));
			this.chkEses.UseVisualStyleBackColor = true;
			// 
			// chkFrfr
			// 
			resources.ApplyResources(this.chkFrfr, "chkFrfr");
			this.chkFrfr.Name = "chkFrfr";
			this.chkFrfr.Tag = "3";
			this.warningTooltip.SetToolTip(this.chkFrfr, resources.GetString("chkFrfr.ToolTip"));
			this.chkFrfr.UseVisualStyleBackColor = true;
			// 
			// chkEngb
			// 
			resources.ApplyResources(this.chkEngb, "chkEngb");
			this.chkEngb.Name = "chkEngb";
			this.chkEngb.Tag = "4";
			this.warningTooltip.SetToolTip(this.chkEngb, resources.GetString("chkEngb.ToolTip"));
			this.chkEngb.UseVisualStyleBackColor = true;
			// 
			// btnDirectExit
			// 
			this.btnDirectExit.BackColor = System.Drawing.Color.White;
			resources.ApplyResources(this.btnDirectExit, "btnDirectExit");
			this.btnDirectExit.Name = "btnDirectExit";
			this.warningTooltip.SetToolTip(this.btnDirectExit, resources.GetString("btnDirectExit.ToolTip"));
			this.infoTooltip.SetToolTip(this.btnDirectExit, resources.GetString("btnDirectExit.ToolTip1"));
			this.btnDirectExit.UseVisualStyleBackColor = false;
			this.btnDirectExit.Click += new System.EventHandler(this.btnDirectExit_Click);
			this.btnDirectExit.MouseEnter += new System.EventHandler(this.btnDirectExit_MouseEnter);
			this.btnDirectExit.MouseLeave += new System.EventHandler(this.btnDirectExit_MouseLeave);
			// 
			// warningTooltip
			// 
			this.warningTooltip.AutoPopDelay = 8000;
			this.warningTooltip.InitialDelay = 500;
			this.warningTooltip.ReshowDelay = 100;
			this.warningTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
			this.warningTooltip.ToolTipTitle = "BingWallpaper";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label2.Name = "label2";
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaption;
			this.label6.Name = "label6";
			// 
			// label7
			// 
			resources.ApplyResources(this.label7, "label7");
			this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label7.Name = "label7";
			// 
			// label8
			// 
			resources.ApplyResources(this.label8, "label8");
			this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label8.Name = "label8";
			// 
			// picBanner
			// 
			resources.ApplyResources(this.picBanner, "picBanner");
			this.picBanner.Name = "picBanner";
			this.picBanner.TabStop = false;
			// 
			// infoTooltip
			// 
			this.infoTooltip.AutoPopDelay = 8000;
			this.infoTooltip.InitialDelay = 500;
			this.infoTooltip.ReshowDelay = 100;
			this.infoTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.infoTooltip.ToolTipTitle = "BingWallpaper";
			this.infoTooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.infoTooltip_Popup);
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.picBanner);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnDirectExit);
			this.Controls.Add(this.chkEngb);
			this.Controls.Add(this.chkFrfr);
			this.Controls.Add(this.chkEses);
			this.Controls.Add(this.chkEnus);
			this.Controls.Add(this.chkZhcn);
			this.Controls.Add(this.refreshEngb);
			this.Controls.Add(this.refreshFrfr);
			this.Controls.Add(this.refreshEses);
			this.Controls.Add(this.refreshEnus);
			this.Controls.Add(this.refreshZhcn);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.ltEngb);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.picENGB);
			this.Controls.Add(this.ltFrfr);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.picFRFR);
			this.Controls.Add(this.ltEses);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.picESES);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.chkAutoRun);
			this.Controls.Add(this.ltEnus);
			this.Controls.Add(this.ltZhcn);
			this.Controls.Add(this.picENUS);
			this.Controls.Add(this.labelCustom);
			this.Controls.Add(this.labelZHCN);
			this.Controls.Add(this.picZHCN);
			this.Controls.Add(this.chkAutoExit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.picZHCN)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picENUS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picESES)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFRFR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picENGB)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox chkAutoExit;
		private System.Windows.Forms.PictureBox picZHCN;
		private System.Windows.Forms.Label labelZHCN;
		private System.Windows.Forms.Label labelCustom;
		private System.Windows.Forms.PictureBox picENUS;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.Label ltZhcn;
		private System.Windows.Forms.Label ltEnus;
		private System.Windows.Forms.CheckBox chkAutoRun;
		private System.Windows.Forms.RadioButton rdSaveAll;
		private System.Windows.Forms.RadioButton rdSaveOne;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label ltEses;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox picESES;
		private System.Windows.Forms.Label ltFrfr;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox picFRFR;
		private System.Windows.Forms.Label ltEngb;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox picENGB;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton rdUpdateAll;
		private System.Windows.Forms.RadioButton rdUpdateTwo;
		private System.Windows.Forms.Label refreshZhcn;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.Label refreshEnus;
		private System.Windows.Forms.Label refreshEses;
		private System.Windows.Forms.Label refreshFrfr;
		private System.Windows.Forms.Label refreshEngb;
		private System.Windows.Forms.CheckBox chkZhcn;
		private System.Windows.Forms.CheckBox chkEnus;
		private System.Windows.Forms.CheckBox chkEses;
		private System.Windows.Forms.CheckBox chkFrfr;
		private System.Windows.Forms.CheckBox chkEngb;
		private System.Windows.Forms.Button btnDirectExit;
		private System.Windows.Forms.ToolTip warningTooltip;
		private System.Windows.Forms.ToolTip infoTooltip;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox picBanner;
	}
}

