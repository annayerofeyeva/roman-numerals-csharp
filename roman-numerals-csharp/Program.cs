using System;
using System.Security.Principal;

namespace romannumeralscsharp
{
	public class RomanNumerals
	{
		public static void Main ()
		{
			for (int i = 1; i < 100; i++) 
			{
				Console.WriteLine(TranslateWholeNumber (i));
			}
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

		public static string TranslateWholeNumber (int num)
		{
			string roman = TranslateHundrets (num) + TranslateTens (num) + TranslateUnits (num);
			return roman;
		}
	}
}
