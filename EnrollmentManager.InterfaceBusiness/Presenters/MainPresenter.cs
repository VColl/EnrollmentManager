using EnrollmentManager.InterfaceBusiness.Boundary.Views;

namespace EnrollmentManager.InterfaceBusiness.Presenters
{
    public class MainPresenter
    {
        private readonly FilePresenter _inputFilePathPresenter;
        private readonly FilePresenter _outputFilePathPresenter;
        private readonly ActionsPresenter _actionsPresenter;

        public MainPresenter(FilePresenter inputFilePathPresenter,
            FilePresenter outputFilePathPresenter,
            ActionsPresenter actionsPresenter)
        {
            _inputFilePathPresenter = inputFilePathPresenter;
            _outputFilePathPresenter = outputFilePathPresenter;
            _actionsPresenter = actionsPresenter;
        }

        public void Setup(IMainView view)
        {
            _inputFilePathPresenter.Setup(view.InputFilePathView, view.InputFileView);
            _outputFilePathPresenter.Setup(view.OutputFilePathView, view.OutputFileView);
            _actionsPresenter.Setup(view.ActionsView);
        }
    }
}
