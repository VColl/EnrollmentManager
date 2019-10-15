using EnrollmentManager.InterfaceBusiness.Boundary;
using EnrollmentManager.InterfaceBusiness.Resources;
using System;
using System.Collections.Generic;
using System.IO;

namespace EnrollmentManager.InterfaceBusiness
{
    public interface IExceptionHandler
    {
        void Handle(Exception exception);
    }

    public class ExceptionHandler : IExceptionHandler
    {
        private readonly IDictionary<Type, string> _messages;
        private readonly INotifier _notifier;

        public ExceptionHandler(INotifier notifier)
        {
            _notifier = notifier;

            _messages = new Dictionary<Type, string>
            {
                [typeof(FileNotFoundException)] = Messages.FileNotFound,
                [typeof(UnauthorizedAccessException)] = Messages.UnauthorizedAccess,
                [typeof(NotSupportedException)] = Messages.NotSupportedFile,
                [typeof(DirectoryNotFoundException)] = Messages.DirectoryNotFound,
            };
        }

        public void Handle(Exception exception)
        {
            if (exception == null)
                return;

            if (_messages.TryGetValue(exception.GetType(), out string message))
                _notifier.ShowError(message);
            else
                _notifier.ShowError(Messages.GeneralProblem);
        }
    }
}
