using System;

namespace EnrollmentManager.Business
{
    public interface IFullEnrollmentNumberGenerator
    {
        string Generate(string enrollmentNumber);
    }

    public class FullEnrollmentNumberGenerator : IFullEnrollmentNumberGenerator
    {
        private readonly ICheckDigitCalculator _checkDigitCalculator;
        private readonly IHexadecimalConverter _hexadecimalConverter;

        public FullEnrollmentNumberGenerator(ICheckDigitCalculator checkDigitCalculator, IHexadecimalConverter hexadecimalConverter)
        {
            _checkDigitCalculator = checkDigitCalculator;
            _hexadecimalConverter = hexadecimalConverter;
        }

        public string Generate(string enrollmentNumber)
        {
            if (string.IsNullOrWhiteSpace(enrollmentNumber))
                throw new FormatException(ErrorMessage.INVALID_ENROLLMENT_NUMBER_FORMAT);

            int decimalCheckDigit = _checkDigitCalculator.Calculate(enrollmentNumber);
            string checkDigit = _hexadecimalConverter.ConvertToHexadecimal(decimalCheckDigit);
            enrollmentNumber = FormatEnrollmentNumber(enrollmentNumber);

            return $"{enrollmentNumber}-{checkDigit}";
        }

        private static string FormatEnrollmentNumber(string enrollmentNumber)
        {
            enrollmentNumber = enrollmentNumber.Trim().Replace(" ", string.Empty);
            for (int i = enrollmentNumber.Length; i < 4; i++)
                enrollmentNumber = $"0{enrollmentNumber}";

            return enrollmentNumber;
        }
    }
}
