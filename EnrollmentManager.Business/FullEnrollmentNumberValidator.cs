using System;

namespace EnrollmentManager.Business
{
    public interface IFullEnrollmentNumberValidator
    {
        bool Validate(string fullEnrollmentNumber);
    }

    public class FullEnrollmentNumberValidator : IFullEnrollmentNumberValidator
    {
        private readonly ICheckDigitCalculator _checkDigitCalculator;
        private readonly IHexadecimalConverter _hexadecimalConverter;

        public FullEnrollmentNumberValidator(ICheckDigitCalculator checkDigitCalculator, IHexadecimalConverter hexadecimalConverter)
        {
            _checkDigitCalculator = checkDigitCalculator;
            _hexadecimalConverter = hexadecimalConverter;
        }

        public bool Validate(string fullEnrollmentNumber) //TODO: adicionar out de motivo para resultado falso
        {
            if (string.IsNullOrWhiteSpace(fullEnrollmentNumber))
                return false;

            var splittedEnrNumber = fullEnrollmentNumber.Split('-');
            if (splittedEnrNumber.Length != 2)
                return false;

            int decimalCheckDigit;
            try
            {
                decimalCheckDigit = _checkDigitCalculator.Calculate(splittedEnrNumber[0].Trim());
            }
            catch (FormatException)
            {
                return false;
            }

            string checkDigit;
            try
            {
                checkDigit = _hexadecimalConverter.ConvertToHexadecimal(decimalCheckDigit);
            }
            catch (Exception)
            {
                return false;
            }

            return checkDigit.Equals(splittedEnrNumber[1].Trim(), StringComparison.OrdinalIgnoreCase);
        }
    }
}
