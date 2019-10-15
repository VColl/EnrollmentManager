using EnrollmentManager.Business;
using EnrollmentManager.InterfaceBusiness.Boundary;
using EnrollmentManager.InterfaceBusiness.Boundary.Views;
using EnrollmentManager.InterfaceBusiness.Resources;
using System;
using System.IO;

namespace EnrollmentManager.InterfaceBusiness.Presenters
{
    public class ActionsPresenter
    {
        private readonly IEnrollmentFileGenerator _generator;
        private readonly IEnrollmentFileValidator _validator;
        private readonly IConfiguration _configuration;
        private readonly IExceptionHandler _exceptionHandler;
        private readonly INotifier _notifier;
        private IActionsView _view;

        public ActionsPresenter(IEnrollmentFileGenerator generator, IEnrollmentFileValidator validator,
            IConfiguration configuration, IExceptionHandler exceptionHandler, INotifier notifier)
        {
            _generator = generator;
            _validator = validator;
            _configuration = configuration;
            _exceptionHandler = exceptionHandler;
            _notifier = notifier;
        }

        public void Setup(IActionsView view)
        {
            _view = view;

            _view.Generate += Generate;
            _view.Verify += Validate;
        }

        private void Generate()
        {
            string inputFilePath = _view.ParentView.InputFilePathView.FilePath;
            if (string.IsNullOrWhiteSpace(inputFilePath))
            {
                _notifier.ShowError(Messages.InputFilePathCantBeEmpty);
                return;
            }

            string outputFilePath = _view.ParentView.OutputFilePathView.FilePath;
            if (string.IsNullOrWhiteSpace(inputFilePath))
            {
                _notifier.ShowError(Messages.OutputFilePathCantBeEmpty);
                return;
            }

            try
            {
                _generator.Generate(inputFilePath, outputFilePath,
                    _configuration.IgnoreInvalidLinesIndicator, _configuration.InvalidLineFormatIndicator);

                var outputFileInfo = new FileInfo(outputFilePath);
                _view.ParentView.OutputFilePathView.FilePath = outputFileInfo.FullName;
                _view.ParentView.OutputFilePathView.LoadFile();
            }
            catch (Exception e)
            {
                _exceptionHandler.Handle(e);
            }
        }

        private void Validate()
        {
            string inputFilePath = _view.ParentView.InputFilePathView.FilePath;
            if (string.IsNullOrWhiteSpace(inputFilePath))
            {
                _notifier.ShowError(Messages.InputFilePathCantBeEmpty);
                return;
            }

            string outputFilePath = _view.ParentView.OutputFilePathView.FilePath;
            if (string.IsNullOrWhiteSpace(outputFilePath))
            {
                _notifier.ShowError(Messages.OutputFilePathCantBeEmpty);
                return;
            }

            try
            {
                _validator.Validate(inputFilePath, outputFilePath,
                    _configuration.ValidIndicator, _configuration.InvalidIndicator);

                var outputFileInfo = new FileInfo(outputFilePath);
                _view.ParentView.OutputFilePathView.FilePath = outputFileInfo.FullName;
                _view.ParentView.OutputFilePathView.LoadFile();
            }
            catch (Exception e)
            {
                _exceptionHandler.Handle(e);
            }
        }
    }
}
