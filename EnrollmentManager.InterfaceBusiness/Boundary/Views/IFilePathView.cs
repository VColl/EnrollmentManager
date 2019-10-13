using System;

namespace EnrollmentManager.InterfaceBusiness.Boundary.Views
{
    public interface IFilePathView : IChildView
    {
        /// <summary>
        /// The path of the file that will be displayed in the corresponding file view.
        /// </summary>
        string FilePath { get; }

        /// <summary>
        /// When fired, the file described by the FilePath should be
        /// loaded and displayed in the correspondig file view.
        /// </summary>
        Action LoadFile { get; set; }
    }
}
