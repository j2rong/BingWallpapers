using BingWallpapers.Bing;
using BingWallpapers.Model;
using Microsoft.Win32;
using System;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

namespace BingWallpapers
{
	class ImageInfo
	{
		public string url;
		public string title;
		public string copyright;
	}

	class BingImage
	{
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
		private static int SPI_SETDESKWALLPAPER = 20;

		private string cachePath;
		private int cacheCount;

		public BingImage(int count, string cache)
		{
			this.cacheCount = count;
			this.cachePath = cache;
		}

		private string getHtml(string url)
		{
			string str = "";
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			request.Accept = "/";

			HttpWebResponse response = null;
			Stream responseStream = null;
			StreamReader reader = null;

			try
			{
				response = (HttpWebResponse)request.GetResponse();
				responseStream = response.GetResponseStream();
				reader = new StreamReader(responseStream, Encoding.UTF8);
				str = reader.ReadToEnd();
			}
			finally
			{
				if (reader != null)
				{
					reader.Close();
					reader.Dispose();
				}
				if (responseStream != null)
				{
					responseStream.Close();
					responseStream.Dispose();
				}
				if (response != null)
				{
					response.Close();
				}
			}

			return str;
        }

		public static void DownloadFile(string url, string savePath)
		{
			WebClient client = new WebClient();
			Directory.CreateDirectory(Path.GetDirectoryName(savePath));
			File.Create(savePath).Close();
			client.DownloadFile(url, savePath);
		}

		public ImageInfo getTodayImageInfo(string locale)
		{
			ImageInfo info = new ImageInfo();

			string jsonResponse = this.getHtml(
				"http://global.bing.com/HPImageArchive.aspx?format=js&idx=0&n=1&mkt=" + locale);
			BingResponse.RootObject result = JsonUtil.parse<BingResponse.RootObject>(jsonResponse);
			if (result != null)
			{
				var image = result.images[0];

				if (locale.ToLower().Equals("zh-cn"))
				{
					info.url = image.url;
				}
				else
				{
					info.url = "http://global.bing.com" + image.url;
				}

				int j = image.copyright.IndexOf('(');
				if (j == -1)
				{
					info.title = image.copyright;
					info.copyright = "";
				}
				else
				{
					info.title = image.copyright.Substring(0, j);
					info.copyright = image.copyright.Substring(j + 1);
				}
			}

			return info;
		}

		private static void setWallpaper7(string imgPath)
		{
			string tile = "0";
			string style = "2";

			RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Control Panel\Desktop");
			key.SetValue("TileWallpaper", tile);
			key.SetValue("WallpaperStyle", style);
			key.SetValue("Wallpaper", imgPath);
			key.Close();

			SystemParametersInfo(SPI_SETDESKWALLPAPER, 1, imgPath, 1);
        }

		private static void setWallpaper8(string imgPath)
		{
			SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, imgPath, 1);
		}

		public static bool setWallpaper(string imgPath)
		{
			Version v = Environment.OSVersion.Version;

			if (v.Major == 6 && v.Minor == 1)
			{
				//win7
				setWallpaper7(imgPath);
			}
			else if (v.Major == 6 && v.Minor >= 2)
			{
				//win8, win8.1
				setWallpaper8(imgPath);
			}
			else if (v.Major > 6)
			{
				//win10 major=10, minor=0
				setWallpaper8(imgPath);
			}
			else
			{
				return false;
			}

			return true;
		}

		public void trimTemp(string temp, int count)
		{
			string[] files = Directory.GetFiles(temp);
			if (files.Length > count)
			{
				int num = files.Length - count;
				if (num >= files.Length)
				{
					foreach (string str in files)
						File.Delete(str);
				}
				else
				{
					Array.Sort<string>(files, new DateComparer());
					for (int i = 0; i < num; i++)
						File.Delete(files[i]);
				}
			}
		}

	}
}
