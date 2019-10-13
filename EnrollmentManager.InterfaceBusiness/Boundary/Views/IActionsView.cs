using System;

namespace EnrollmentManager.InterfaceBusiness.Boundary.Views
{
    public interface IActionsView : IChildView
    {
        /// <summary>
        /// Generates the full enrollment number (with the check digit) for each enrollment
        /// number in the input file and publish them into the output file.
        /// </summary>
        Action Generate { get; set; }

        /// <summary>
        /// Verifies each enrollment number in the input file and publish them with
        /// their respective results into the output file.
        /// </summary>
        Action Validate { get; set; }
    }
}
