using System;

namespace EnrollmentManager.Business
{
    public interface ICheckDigitCalculator
    {
        /// <summary>
        /// Calculates the check digit in its decimal representation.
        /// </summary>
        /// <param name="enrollmentNumber">The enrollment number.</param>
        /// <returns>The check digit.</returns>
        int Calculate(string enrollmentNumber);
    }

    public class CheckDigitCalculator : ICheckDigitCalculator
    {
        private const string FORMAT_ERROR_MESSAGE = "The enrollmentNumber should be a number between 0 and 9999";

        public int Calculate(string enrollmentNumber)
        {
            enrollmentNumber = enrollmentNumber.Trim().Replace(" ", string.Empty);

            if (!ValidateFormat(enrollmentNumber))
                throw new FormatException(FORMAT_ERROR_MESSAGE);

            int sum = 0;

            sum += (enrollmentNumber[enrollmentNumber.Length - 1] - '0') * 2;

            if (enrollmentNumber.Length >= 2)
                sum += (enrollmentNumber[enrollmentNumber.Length - 2] - '0') * 3;

            if (enrollmentNumber.Length >= 3)
                sum += (enrollmentNumber[enrollmentNumber.Length - 3] - '0') * 4;

            if (enrollmentNumber.Length >= 4)
                sum += (enrollmentNumber[enrollmentNumber.Length - 4] - '0') * 5;

            Math.DivRem(sum, 16, out int checkDigit);
            return checkDigit;
        }

        private static bool ValidateFormat(string enrollmentNumber)
        {
            if (enrollmentNumber.Length > 4)
                return false;

            try
            {
                int number = Convert.ToInt32(enrollmentNumber);
                return (number >= 0 && number <= 9999);
            }
            catch
            {
                return false;
            }
        }
    }
}
