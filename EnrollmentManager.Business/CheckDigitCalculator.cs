using System;
using System.Collections.Generic;
using System.Text;

namespace EnrollmentManager.Business
{
    public interface ICheckDigitCalculator
    {
        /// <summary>
        /// Calculates the check digit in its decimal representation.
        /// </summary>
        /// <param name="enrollmentNumber">The enrollment number.</param>
        /// <returns>The check digit.</returns>
        int Calculate(int enrollmentNumber);
    }

    public class CheckDigitCalculator : ICheckDigitCalculator
    {
        public int Calculate(int enrollmentNumber)
        {
            return 0;
        }
    }
}
