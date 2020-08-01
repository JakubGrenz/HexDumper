using System;

namespace HexDumper
{
	public static class HexDumperMath
	{
		public static int Log16(this int input)
		{
			return (int)Math.Floor(Math.Log(input, 16));
		}

		public static int ExtremeValuesToZero(this int input)
		{
			if (input == int.MaxValue || input == int.MinValue)
				return 0;

			return input;
		}
	}
}
