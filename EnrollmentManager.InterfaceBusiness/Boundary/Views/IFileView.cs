namespace EnrollmentManager.InterfaceBusiness.Boundary.Views
{
    public interface IFileView : IChildView
    {
        /// <summary>
        /// The name of the file.
        /// </summary>
        string FileName { get; set; }

        /// <summary>
        /// The content of the file.
        /// </summary>
        string FileContent { get; set; }

        /// <summary>
        /// Cleans the file name and content.
        /// </summary>
        void Clean();
    }
}
