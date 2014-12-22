using NUnit.Framework;
using System;
using System.Collections.Generic;
using romannumeralscsharp;
using System.Collections;

namespace UnitTests
{
	[TestFixture ()]
	public class RomanNumeralsTests
	{

		[Test ()]
		public void TestingTranslateUnits ()
		{
			Dictionary<int, string> tests = new Dictionary<int, string> ();
			tests[1] = "I";
			tests[5] = "V";
			tests[10] = "";
			tests[16] = "VI";
			tests[399] = "IX";

			foreach(KeyValuePair<int, string> test in tests ) 
			{
				Assert.AreEqual (RomanNumerals.TranslateUnits (test.Key), test.Value);
			}
		}

		[Test ()]
		public void TestingTranslateTens ()
		{
			Dictionary<int, string> tests = new Dictionary<int, string> ();
			tests[10] = "X";
			tests[55] = "L";
			tests[100] = "";
			tests[514] = "X";
			tests[399] = "XC";

			foreach(KeyValuePair<int, string> test in tests ) 
			{
				Assert.AreEqual (RomanNumerals.TranslateTens (test.Key), test.Value);
			}
		}

		[Test ()]
		public void TestingTranslateHundrets ()
		{
			Dictionary<int, string> tests = new Dictionary<int, string> ();
			tests[100] = "C";
			tests[555] = "D";
			tests[1000] = "";
			tests[1698] = "DC";
			tests[1999] = "CM";

			foreach(KeyValuePair<int, string> test in tests ) 
			{
				Assert.AreEqual (RomanNumerals.TranslateHundrets (test.Key), test.Value);
			}
		}
	}
}

