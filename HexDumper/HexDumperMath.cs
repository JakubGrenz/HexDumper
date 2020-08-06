using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("HexDumper.Tests")]
namespace HexDumper
{
	internal static class HexDumperMath
	{
		internal static int Log16(this int input)
		{
			return (int)Math.Floor(Math.Log(input, 16));
		}

		internal static int ExtremeValuesToZero(this int input)
		{
			if (input == int.MaxValue || input == int.MinValue)
				return 0;

			return input;
		}
	}
}
