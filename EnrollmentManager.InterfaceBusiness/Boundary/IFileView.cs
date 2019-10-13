using System;

namespace EnrollmentManager.InterfaceBusiness.Boundary
{
    public interface IFileView
    {
        string FileName { get; set; }
        Action SaveFile { get; set; }
        Action RemoveWhiteSpaces { get; set; }
    }
}
