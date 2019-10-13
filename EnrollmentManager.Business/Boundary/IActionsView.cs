using System;

namespace EnrollmentManager.Business.Boundary
{
    public interface IActionsView
    {
        /// <summary>
        /// Generates the full enrollment number (with the check digit) for each enrollment
        /// number in the input file and publish them into the output file.
        /// </summary>
        Action Generate();

        /// <summary>
        /// Verifies each enrollment number in the input file and publish them with
        /// their respective results into the output file.
        /// </summary>
        Action Verify();
    }
}
