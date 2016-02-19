using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BingWallpapers
{
	class Ini
	{

		[DllImport("kernel32")]
		private static extern int GetPrivateProfileString(
			string section, string key, string def, StringBuilder retVal, int size, string filePath);

		[DllImport("kernel32")]
		private static extern long WritePrivateProfileString(
			string section, string key, string val, string filePath);

		public static string Read(string filePath, string section, string key, string def)
		{
			StringBuilder retVal = new StringBuilder(0x400);
			try
			{
				GetPrivateProfileString(section, key, def, retVal, 0x400, filePath);
			}
			catch
			{
			}
			return retVal.ToString();
		}

		public static void Write(string filePath, string section, string key, string value)
		{
			WritePrivateProfileString(section, key, value, filePath);
		}
		
	}

}

