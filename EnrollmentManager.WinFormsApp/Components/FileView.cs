using EnrollmentManager.InterfaceBusiness.Boundary.Views;
using System.Windows.Forms;

namespace EnrollmentManager.WinFormsApp.Components
{
    public partial class FileView : UserControl, IFileView
    {
        public IMainView ParentView { get ; set; }

        public string FileName
        {
            get => gbFileContent.Text;
            set => gbFileContent.Text = value;
        }

        public string FileContent
        {
            get => tbFileContent.Text;
            set => tbFileContent.Text = value;
        }

        public FileView()
        {
            InitializeComponent();
        }

        public void Clean()
        {
            FileName = string.Empty;
            FileContent = string.Empty;
        }
    }
}
