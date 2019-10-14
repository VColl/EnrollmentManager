using EnrollmentManager.InterfaceBusiness.Boundary.Views;

namespace EnrollmentManager.InterfaceBusiness.Presenters
{
    public class MainPresenter
    {
        private readonly FilePresenter _inputFilePresenter;
        private readonly FilePresenter _outputFilePresenter;
        private readonly ActionsPresenter _actionsPresenter;

        public MainPresenter(FilePresenter inputFilePresenter,
            FilePresenter outputFilePresenter,
            ActionsPresenter actionsPresenter)
        {
            _inputFilePresenter = inputFilePresenter;
            _outputFilePresenter = outputFilePresenter;
            _actionsPresenter = actionsPresenter;
        }

        public void Setup(IMainView view)
        {
            _inputFilePresenter.Setup(view.InputFilePathView, view.InputFileView);
            _outputFilePresenter.Setup(view.OutputFilePathView, view.OutputFileView);
            _actionsPresenter.Setup(view.ActionsView);
        }
    }
}
