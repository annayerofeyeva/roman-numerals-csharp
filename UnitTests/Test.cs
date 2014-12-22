using NUnit.Framework;
using System;
using romannumeralscsharp;

namespace UnitTests
{
	[TestFixture ()]
	public class RomanNumeralsTests
	{

		[Test ()]
		public void TestingTranslateUnits ()
		{
			Assert.AreEqual ("I", RomanNumerals.TranslateUnits (1));
			Assert.AreEqual ("V", RomanNumerals.TranslateUnits (5));
			Assert.AreEqual ("", RomanNumerals.TranslateUnits (10));
		}
	}
}

