using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Collections.Generic;

namespace HexDumper.Tests
{
	[TestFixture]
	public class HexDumperTests
	{
		private static List<HexDumpTestCase> _testCases = Data.HexDumpTestCases;

		[Test]
		public void ConvertBytesToString()
		{
			foreach (var testCase in _testCases) {
				var result = ByteConverter.ConvertToHexDump(testCase.Bytes);

				Assert.That(result.Equals(testCase.ExpectedHexDump));
			}
		}
	}
}