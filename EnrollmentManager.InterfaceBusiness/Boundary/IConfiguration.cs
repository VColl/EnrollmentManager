namespace EnrollmentManager.InterfaceBusiness.Boundary
{
    public interface IConfiguration
    {
        /// <summary>
        /// The indicator that will be displayed in the output line when the
        /// input line is a valid enrollment number on the enrollment file validation.
        /// </summary>
        string ValidIndicator { get; }

        /// <summary>
        /// The indicator that will be displayed in the output line when the
        /// input line is an invalid enrollment number on the enrollment file validation.
        /// </summary>
        string InvalidIndicator { get; }

        /// <summary>
        /// The indicator that will be displayed in the output line when the
        /// input line is in an invalid format on the enrollment file generation.
        /// </summary>
        string InvalidLineFormatIndicator { get; }

        /// <summary>
        /// Indicates whenever the invalid input lines will not be displayed
        /// in the output file on the enrollment file generation.
        /// </summary>
        bool IgnoreInvalidLinesIndicator { get; }
    }
}
