using EnrollmentManager.InterfaceBusiness.Boundary;
using EnrollmentManager.InterfaceBusiness.Boundary.Views;
using EnrollmentManager.InterfaceBusiness.Resources;
using System;
using System.IO;

namespace EnrollmentManager.InterfaceBusiness.Presenters
{
    public class FilePresenter
    {
        private readonly IExceptionHandler _exceptionHandler;
        private readonly INotifier _notifier;
        private IFilePathView _filePathView;
        private IFileView _fileView;

        public FilePresenter(IExceptionHandler exceptionHandler, INotifier notifier)
        {
            _exceptionHandler = exceptionHandler;
            _notifier = notifier;
        }

        internal void Setup(IFilePathView filePathView, IFileView fileView)
        {
            _filePathView = filePathView;
            _fileView = fileView;

            _filePathView.LoadFile += LoadFile;
        }

        private void LoadFile()
        {
            string filePath = _filePathView.FilePath;
            if (string.IsNullOrWhiteSpace(filePath))
            {
                _fileView.Clean();
                _notifier.ShowError(Messages.FilePathCantBeEmpty);
                return;
            }

            FileInfo fileInfo;
            string content;
            try
            {
                fileInfo = new FileInfo(filePath);
                content = File.ReadAllText(filePath);
            }
            catch (Exception e)
            {
                _fileView.Clean();
                _exceptionHandler.Handle(e);
                return;
            }

            _fileView.FileName = fileInfo.Name;
            _fileView.FileContent = content;
        }
    }
}
