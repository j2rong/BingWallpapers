using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingWallpapers
{
	class Settings
	{
		private static readonly string iniFile = AppDomain.CurrentDomain.BaseDirectory + "Settings.ini";
		private static string SETTINGS = "Settings";

		private static string idAutoRun = "AutoRun";
		private static string idUpdateAll = "UpdateAll";

		private static string idSaveAll = "SaveAll";
		private static string idAutoExit = "AutoExit";

		private static string idTitlePrefix = "t";
		private static string idCopyrightPrefix = "c";

		public static bool AutoRun
		{
			get
			{
				return Boolean.Parse(Ini.Read(iniFile, SETTINGS, idAutoRun, bool.TrueString));
			}
			set
			{
				Ini.Write(iniFile, SETTINGS, idAutoRun, value.ToString());
			}
		}

		public static bool UpdateAll
		{
			get
			{
				return Boolean.Parse(Ini.Read(iniFile, SETTINGS, idUpdateAll, bool.TrueString));
			}
			set
			{
				Ini.Write(iniFile, SETTINGS, idUpdateAll, value.ToString());
			}
		}

		public static bool SaveAll
		{
			get
			{
				return Boolean.Parse(Ini.Read(iniFile, SETTINGS, idSaveAll, bool.TrueString));
			}
			set
			{
				Ini.Write(iniFile, SETTINGS, idSaveAll, value.ToString());
			}
		}

		public static bool AutoExit
		{
			get
			{
				return Boolean.Parse(Ini.Read(iniFile, SETTINGS, idAutoExit, bool.TrueString));
			}
			set
			{
				Ini.Write(iniFile, SETTINGS, idAutoExit, value.ToString());
			}
		}

		public static string Title(string locale)
		{
			return Ini.Read(iniFile, SETTINGS, idTitlePrefix + locale, "");
		}

		public static void Title(string locale, string value)
		{
			Ini.Write(iniFile, SETTINGS, idTitlePrefix + locale, value);
		}

		public static string Copyright(string locale)
		{
			return Ini.Read(iniFile, SETTINGS, idCopyrightPrefix + locale, "");
		}

		public static void Copyright(string locale, string value)
		{
			Ini.Write(iniFile, SETTINGS, idCopyrightPrefix + locale, value);
		}


	}


}
