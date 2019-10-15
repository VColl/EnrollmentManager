using EnrollmentManager.InterfaceBusiness.Boundary;
using EnrollmentManager.InterfaceBusiness.Boundary.Views;
using EnrollmentManager.InterfaceBusiness.Tests.Builders;
using Moq;
using TechTalk.SpecFlow;

namespace EnrollmentManager.InterfaceBusiness.Tests
{
    [Binding]
    [Scope(Feature = "ActionsPresenter")]
    public class ActionsPresenterSteps
    {
        private readonly ActionsPresenterBuilder _builder = new ActionsPresenterBuilder();
        private readonly Mock<INotifier> _mqNotifier = new Mock<INotifier>();
        private IActionsView _view;

        [Given(@"The input file path is empty")]
        public void GivenTheInputFilePathIsEmpty()
        {
            var mqInputFilePathView = new Mock<IFilePathView>();
            mqInputFilePathView
                .SetupGet(v => v.FilePath)
                .Returns(() => null);

            var mqMainView = new Mock<IMainView>();
            mqMainView
                .SetupGet(v => v.InputFilePathView)
                .Returns(mqInputFilePathView.Object);

            mqMainView
                .SetupGet(v => v.OutputFilePathView)
                .Returns(Mock.Of<IFilePathView>());

            var mqActionsView = new Mock<IActionsView>();
            mqActionsView
                .SetupProperty(v => v.Generate)
                .SetupProperty(v => v.Verify)
                .SetupGet(v => v.ParentView)
                .Returns(mqMainView.Object);

            _view = mqActionsView.Object;
        }

        [Given(@"The output file path is empty")]
        public void GivenTheOutputFilePathIsEmpty()
        {
            var mqOutputFilePathView = new Mock<IFilePathView>();
            mqOutputFilePathView
                .SetupGet(v => v.FilePath)
                .Returns(() => null);

            var mqMainView = new Mock<IMainView>();
            mqMainView
                .SetupGet(v => v.InputFilePathView)
                .Returns(Mock.Of<IFilePathView>());

            mqMainView
                .SetupGet(v => v.OutputFilePathView)
                .Returns(mqOutputFilePathView.Object);

            var mqActionsView = new Mock<IActionsView>();
            mqActionsView
                .SetupProperty(v => v.Generate)
                .SetupProperty(v => v.Verify)
                .SetupGet(v => v.ParentView)
                .Returns(mqMainView.Object);

            _view = mqActionsView.Object;
        }

        [When(@"I press the Generate button")]
        public void WhenIPressTheGenerateButton()
        {
            var presenter = _builder.WithNotifier(_mqNotifier.Object).Build();
            presenter.Setup(_view);

            _view.Generate.Invoke();
        }

        [When(@"I press the Verify button")]
        public void WhenIPressTheVerifyButton()
        {
            var presenter = _builder.WithNotifier(_mqNotifier.Object).Build();
            presenter.Setup(_view);

            _view.Verify.Invoke();
        }

        [Then(@"an error message should be shown")]
        public void ThenAnErrorMessageShouldBeShown()
        {
            _mqNotifier.Verify(n => n.ShowError(It.IsAny<string>()));
        }
    }
}
