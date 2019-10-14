using EnrollmentManager.Business;
using EnrollmentManager.InterfaceBusiness.Boundary;
using EnrollmentManager.InterfaceBusiness.Boundary.Views;

namespace EnrollmentManager.InterfaceBusiness.Presenters
{
    public class ActionsPresenter
    {
        private readonly IEnrollmentFileGenerator _generator;
        private readonly IEnrollmentFileValidator _validator;
        private readonly IConfiguration _configuration;
        private IActionsView _view;

        public ActionsPresenter(IEnrollmentFileGenerator generator, IEnrollmentFileValidator validator, IConfiguration configuration)
        {
            _generator = generator;
            _validator = validator;
            _configuration = configuration;
        }

        public void Setup(IActionsView view)
        {
            _view = view;

            _view.Generate += Generate;
            _view.Verify += Validate;
        }

        private void Generate()
        {
            _generator.Generate(_view.ParentView.InputFilePathView.FilePath, _view.ParentView.OutputFilePathView.FilePath,
                _configuration.IgnoreInvalidLinesIndicator, _configuration.InvalidLineFormatIndicator);
        }

        private void Validate()
        {
            _validator.Validate(_view.ParentView.InputFilePathView.FilePath, _view.ParentView.OutputFilePathView.FilePath);
        }
    }
}
