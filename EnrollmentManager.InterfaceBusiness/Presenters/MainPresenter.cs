using EnrollmentManager.Business;
using EnrollmentManager.InterfaceBusiness.Boundary;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnrollmentManager.Presenters.InterfaceBusiness
{
    public class MainPresenter
    {
        private IMainView _view;
        private readonly IFullEnrollmentNumberGenerator _generator;
        private readonly IFullEnrollmentNumberValidator _validator;

        public MainPresenter(IFullEnrollmentNumberGenerator generator, IFullEnrollmentNumberValidator validator)
        {
            _generator = generator;
            _validator = validator;
        }

        public void Setup(IMainView view)
        {
            _view = view;
        }
    }
}
