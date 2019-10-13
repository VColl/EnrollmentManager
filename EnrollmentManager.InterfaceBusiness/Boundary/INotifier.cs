using System;
using System.Collections.Generic;
using System.Text;

namespace EnrollmentManager.InterfaceBusiness.Boundary
{
    public interface INotifier
    {
        void ShowError(string message);
    }
}
