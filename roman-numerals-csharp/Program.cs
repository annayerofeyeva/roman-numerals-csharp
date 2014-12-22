using System;
using System.Security.Principal;

namespace romannumeralscsharp
{
	public class RomanNumerals
	{
		public static void Main ()
		{
			Console.WriteLine(TranslateUnits (2));
			Console.WriteLine(TranslateTenths (20));
		}

		public static string TranslateUnits (int num)
		{
			string[] units = new string[10] {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
			return units [num % 10];
		}

		public static string TranslateTenths (int num)
		{
			string[] tenths = new string[10] {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
			return tenths[(num % 100) / 10];
		}
	}
}
