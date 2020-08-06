using System;
using System.Linq;
using System.Text;

namespace HexDumper
{
	public static class ByteConverter
	{
		public static string ConvertToHexDump(byte[] bytes)
		{
			string result = string.Empty;
			for(int i = 0; i < bytes.Length; i += 16)
			{
				if (i > 0) result += '\n';
				int padding = bytes.Length.Log16().ExtremeValuesToZero() - i.Log16().ExtremeValuesToZero() + 1;
				byte[] bytesChunk = bytes.Skip(i).Take(16).ToArray();
				result += $"{i:X}".PadLeft(padding, '0').PadRight(5, ' ');
				result += ConvertBytesToHex(bytesChunk);
				result += string.Empty.PadRight((17 - bytesChunk.Length) * 3, ' ');
				result += ConvertBytesToString(bytesChunk);
			}

			return result;
		}

		private static string ConvertBytesToHex(byte[] bytes)
		{
			string hexDump = BitConverter.ToString(bytes);
			hexDump = hexDump.Replace("-", " ");

			return hexDump.ToLower();
		}

		private static string ConvertBytesToString(byte[] bytes)
		{
			string result = string.Empty;
			foreach(var hex in bytes) {
				char mark = Encoding.ASCII.GetChars(new byte[] { hex })[0];
				if (char.IsControl(mark) || char.IsSurrogate(mark) || mark.Equals('?'))
					result += '.';
				else
					result += mark;
			}

			return result;
		}
	}
}
