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
			Assert.AreEqual ("III", RomanNumerals.TranslateUnits (13));
		}

		[Test ()]
		public void TestingTranslatingTens ()
		{
			Assert.AreEqual ("X", RomanNumerals.TranslateTens (10));
			Assert.AreEqual ("L", RomanNumerals.TranslateTens (55));
			Assert.AreEqual ("", RomanNumerals.TranslateTens (100));
			Assert.AreEqual ("X", RomanNumerals.TranslateTens (514));
		}

		[Test ()]
		public void TestingTranslatingHundrets ()
		{
			Assert.AreEqual ("C", RomanNumerals.TranslateHundrets (100));
			Assert.AreEqual ("D", RomanNumerals.TranslateHundrets (555));
			Assert.AreEqual ("", RomanNumerals.TranslateHundrets (1000));
			Assert.AreEqual ("DC", RomanNumerals.TranslateHundrets (1698));
		}
	}
}

