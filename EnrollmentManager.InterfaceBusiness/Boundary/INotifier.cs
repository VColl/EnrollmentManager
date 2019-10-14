namespace EnrollmentManager.InterfaceBusiness.Boundary
{
    public interface INotifier
    {
        void ShowError(string message);
        void ShowWarning(string message);
        void ShowInformation(string message);
    }
}
