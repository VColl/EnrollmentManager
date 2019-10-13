using System;

namespace EnrollmentManager.Business.Boundary
{
    public interface IFileView
    {
        string FileName { get; set; }
        Action SaveFile { get; set; }
        Action RemoveWhiteSpaces { get; set; }
    }
}
