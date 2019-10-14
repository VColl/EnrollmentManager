using EnrollmentManager.InterfaceBusiness.Boundary.Views;
using EnrollmentManager.InterfaceBusiness.Presenters;
using Ninject;
using System.Windows.Forms;

namespace EnrollmentManager.WinFormsApp
{
    public partial class MainView : Form, IMainView
    {
        public IFilePathView InputFilePathView => inputFilePathView;
        public IFilePathView OutputFilePathView => outputFilePathView;
        public IFileView InputFileView => inputFileView;
        public IFileView OutputFileView => outputFileView;
        public IActionsView ActionsView => actionsView;

        public MainView()
        {
            InitializeComponent();

            inputFilePathView.ParentView = this;
            outputFilePathView.ParentView = this;
            inputFileView.ParentView = this;
            outputFileView.ParentView = this;
            actionsView.ParentView = this;
        }

        [Inject]
        public MainView(MainPresenter mainPresenter)
            : this()
        {
            mainPresenter.Setup(this);
        }
    }
}
