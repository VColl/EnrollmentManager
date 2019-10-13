using EnrollmentManager.InterfaceBusiness.Boundary;
using EnrollmentManager.InterfaceBusiness.Boundary.Views;
using EnrollmentManager.InterfaceBusiness.Resources;
using System;
using System.IO;

namespace EnrollmentManager.InterfaceBusiness.Presenters
{
    public class FilePresenter
    {
        private readonly INotifier _notifier;
        private IFilePathView _filePathView;
        private IFileView _fileView;

        public FilePresenter(INotifier notifier)
        {
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
            if (string.IsNullOrWhiteSpace(_filePathView.FilePath))
            {
                _fileView.Clean();
                _notifier.ShowError(Messages.FilePathCantBeEmpty);
                return;
            }

            var fileInfo = new FileInfo(_filePathView.FilePath);
            if (!fileInfo.Exists)
            {
                _fileView.Clean();
                _notifier.ShowError(Messages.FileNotFound);
                return;
            }

            string content;
            try
            {
                content = File.ReadAllText(_filePathView.FilePath);
            }
            catch (NotSupportedException)
            {
                _fileView.Clean();
                _notifier.ShowError(Messages.NotSupportedFile);
                return;
            }
            catch (UnauthorizedAccessException)
            {
                _fileView.Clean();
                _notifier.ShowError(Messages.UnauthorizedAccess);
                return;
            }
            catch
            {
                _fileView.Clean();
                _notifier.ShowError(Messages.GeneralProblem);
                return;
            }

            _fileView.FileName = fileInfo.Name;
            _fileView.FileContent = content;
        }
    }
}
