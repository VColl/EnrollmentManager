using System;
using System.Collections.Generic;
using System.Text;

namespace EnrollmentManager.Business
{
	public interface IHexadecimalConverter
	{
		/// <summary>
		/// Converts an integer from decimal representation to the hexadecimal representation.
		/// </summary>
		/// <param name="decimalInt">The integer in decimal representation.</param>
		/// <returns>The integer in hexadecimal representarion.</returns>
		string ConvertToHexadecimal(int decimalInt);
	}

	public class HexadecimalConverter : IHexadecimalConverter
	{
        private readonly IReadOnlyDictionary<int, string> _hexadecimals;

        public HexadecimalConverter()
        {
            _hexadecimals = new Dictionary<int, string>
            {
                [10] = "A",
                [11] = "B",
                [12] = "C",
                [13] = "D",
                [14] = "E",
                [15] = "F"
            };
        }

		public string ConvertToHexadecimal(int decimalInt)
		{
            if (decimalInt >= 0 && decimalInt <= 9)
                return decimalInt.ToString();

            if (_hexadecimals.TryGetValue(decimalInt, out string hexadecimal))
                return hexadecimal;

            throw new ArgumentOutOfRangeException("decimalInt", "The value should be between 0 and 15");
		}
	}
}
