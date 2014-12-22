﻿using NUnit.Framework;
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

		[Test ()]
		public void TestingTranslatingTenths ()
		{
			Assert.AreEqual ("X", RomanNumerals.TranslateTenths (10));
			Assert.AreEqual ("L", RomanNumerals.TranslateTenths (55));
			Assert.AreEqual ("", RomanNumerals.TranslateTenths (100));
		}
	}
}

