using EnrollmentManager.InterfaceBusiness.Boundary.Views;
using System;
using System.Windows.Forms;

namespace EnrollmentManager.WinFormsApp.Components
{
    public partial class ActionsView : UserControl, IActionsView
    {
        public IMainView ParentView { get; set; }
        public Action Generate { get; set; }
        public Action Verify { get; set; }

        public ActionsView()
        {
            InitializeComponent();

            btGenerate.Click += (obj, args) => Generate?.Invoke();
            tbVerify.Click += (obj, args) => Verify?.Invoke();
        }
    }
}
