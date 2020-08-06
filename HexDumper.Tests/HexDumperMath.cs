using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HexDumper.Tests
{
	public class HexDumperMath
	{
		[TestCase(0, int.MinValue)]
		[TestCase(15, 0)]
		[TestCase(16, 1)]
		[TestCase(272, 2)]
		[TestCase(4368, 3)]
		public void Log16Tests(int input, int expectedResult)
		{
			var result = input.Log16();

			Assert.That(expectedResult.Equals(result));
		}

		[TestCase(int.MaxValue, 0)]
		[TestCase(int.MinValue, 0)]
		public void ExtremeValuesToZeroTests(int input, int expectedResult)
		{
			var result = input.ExtremeValuesToZero();

			Assert.That(expectedResult.Equals(result));
		}
	}
}
