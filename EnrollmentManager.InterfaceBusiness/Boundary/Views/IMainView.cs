namespace EnrollmentManager.InterfaceBusiness.Boundary.Views
{
    public interface IMainView
    {
        IFilePathView InputFilePathView { get; set; }
        IFilePathView OutputFilePathView { get; set; }
        IFileView InputFileView { get; set; }
        IFileView OutputFileView { get; set; }
        IActionsView ActionsView { get; set; }
    }

    public interface IChildView
    {
        /// <summary>
        /// The main view that contains this one.
        /// </summary>
        IMainView MainView { get; }
    }
}
