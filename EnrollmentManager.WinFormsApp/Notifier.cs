using EnrollmentManager.InterfaceBusiness.Boundary;
using EnrollmentManager.WinFormsApp.Properties;
using System.Windows.Forms;

namespace EnrollmentManager.WinFormsApp
{
    internal class Notifier : INotifier
    {
        public void ShowError(string message) =>
            MessageBox.Show(message, Resources.ErollmentManager, MessageBoxButtons.OK, MessageBoxIcon.Error);

        public void ShowInformation(string message) =>
            MessageBox.Show(message, Resources.ErollmentManager, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public void ShowWarning(string message) =>
            MessageBox.Show(message, Resources.ErollmentManager, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
