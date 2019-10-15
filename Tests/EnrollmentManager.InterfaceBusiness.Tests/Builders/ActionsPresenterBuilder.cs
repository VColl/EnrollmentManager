using EnrollmentManager.Business;
using EnrollmentManager.InterfaceBusiness.Boundary;
using EnrollmentManager.InterfaceBusiness.Presenters;
using Moq;

namespace EnrollmentManager.InterfaceBusiness.Tests.Builders
{
    internal class ActionsPresenterBuilder
    {
        private IEnrollmentFileGenerator _generator = Mock.Of<IEnrollmentFileGenerator>();
        private IEnrollmentFileValidator _validator = Mock.Of<IEnrollmentFileValidator>();
        private IConfiguration _configuration = Mock.Of<IConfiguration>();
        private IExceptionHandler _exceptionHandler = Mock.Of<IExceptionHandler>();
        private INotifier _notifier = Mock.Of<INotifier>();

        public ActionsPresenterBuilder WithGenerator(IEnrollmentFileGenerator generator)
        {
            _generator = generator;
            return this;
        }

        public ActionsPresenterBuilder WithValidator(IEnrollmentFileValidator validator)
        {
            _validator = validator;
            return this;
        }

        public ActionsPresenterBuilder WithConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
            return this;
        }

        public ActionsPresenterBuilder WithExceptionHandler(IExceptionHandler exceptionHandler)
        {
            _exceptionHandler = exceptionHandler;
            return this;
        }

        public ActionsPresenterBuilder WithNotifier(INotifier notifier)
        {
            _notifier = notifier;
            return this;
        }

        public ActionsPresenter Build() =>
            new ActionsPresenter(_generator, _validator, _configuration, _exceptionHandler, _notifier);
    }
}
