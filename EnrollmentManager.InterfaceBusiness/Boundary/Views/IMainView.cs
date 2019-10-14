namespace EnrollmentManager.InterfaceBusiness.Boundary.Views
{
    public interface IMainView
    {
        IFilePathView InputFilePathView { get; }
        IFilePathView OutputFilePathView { get; }
        IFileView InputFileView { get; }
        IFileView OutputFileView { get; }
        IActionsView ActionsView { get; }
    }

    public interface IChildView
    {
        /// <summary>
        /// The view that contains this one.
        /// </summary>
        IMainView ParentView { get; set; }
    }
}
