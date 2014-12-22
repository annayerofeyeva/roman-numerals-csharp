using System;
using System.Security.Principal;

namespace romannumeralscsharp
{
	public class RomanNumerals
	{
		public static void Main ()
		{
			Console.WriteLine(TranslateUnits (2));
		}

		public static string TranslateUnits (int num)
		{
			string[] units = new string[10] {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
			return units [(num % 10)];
		}
	}
}
