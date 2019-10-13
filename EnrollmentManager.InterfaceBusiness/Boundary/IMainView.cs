namespace EnrollmentManager.InterfaceBusiness.Boundary
{
    public interface IMainView
    {
        IFilePathView InputFilePathView { get; set; }
        IFilePathView OutputFilePathView { get; set; }
        IFileView InputFileView { get; set; }
        IFileView OutputFileView { get; set; }
        IActionsView ActionsView { get; set; }
    }
}
