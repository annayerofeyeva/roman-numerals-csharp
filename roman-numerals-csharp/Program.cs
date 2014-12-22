using System;
using System.Security.Principal;

namespace romannumeralscsharp
{
	public class RomanNumerals
	{
		public static void Main ()
		{
			Console.WriteLine(TranslateUnits (2));
			Console.WriteLine(TranslateTens (20));
			Console.WriteLine(TranslateHundrets (200));
		}

		public static string TranslateUnits (int num)
		{
			string[] units = new string[10] {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
			return units [num % 10];
		}

		public static string TranslateTens (int num)
		{
			string[] tens = new string[10] {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
			return tens[(num % 100) / 10];
		}

		public static string TranslateHundrets (int num)
		{
			string[] hundrets = new string[10] {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};
			return hundrets[(num % 1000) / 100];
		}
	}
}
