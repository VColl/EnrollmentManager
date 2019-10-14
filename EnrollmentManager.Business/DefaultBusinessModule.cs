using Ninject.Modules;

namespace EnrollmentManager.Business
{
    public class DefaultBusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICheckDigitCalculator>().To<CheckDigitCalculator>();
            Bind<IEnrollmentFileGenerator>().To<EnrollmentFileGenerator>();
            Bind<IEnrollmentFileValidator>().To<EnrollmentFileValidator>();
            Bind<IFullEnrollmentNumberGenerator>().To<FullEnrollmentNumberGenerator>();
            Bind<IFullEnrollmentNumberValidator>().To<FullEnrollmentNumberValidator>();
            Bind<IHexadecimalConverter>().To<HexadecimalConverter>();
        }
    }
}
