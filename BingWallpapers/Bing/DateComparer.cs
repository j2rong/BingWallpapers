using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingWallpapers
{
	class DateComparer : IComparer<string>
	{
		public static DateTime ParseDateTimeFormatString(string fStr)
		{
			int year = int.Parse(fStr.Substring(0, 4));
			int month = int.Parse(fStr.Substring(5, 2));
			int day = int.Parse(fStr.Substring(8, 2));
			return new DateTime(year, month, day, 0, 0, 0);
		}

		public int Compare(string x, string y)
		{
			return DateTime.Compare(
				ParseDateTimeFormatString(Path.GetFileNameWithoutExtension(x)),
				ParseDateTimeFormatString(Path.GetFileNameWithoutExtension(y)));
		}
	}
}
