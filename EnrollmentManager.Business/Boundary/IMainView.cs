namespace EnrollmentManager.Business.Boundary
{
    public interface IMainView
    {
        /// <summary>
        /// 
        /// </summary>
        IFilePathView FilePathView { get; set; }

        /// <summary>
        /// 
        /// </summary>
        IFileView FileView { get; set; }

        /// <summary>
        /// 
        /// </summary>
        IActionsView ActionsView { get; set; }
    }
}
