using EnrollmentManager.InterfaceBusiness.Boundary;
using System;
using System.Configuration;

namespace EnrollmentManager.WinFormsApp
{
    internal class Configuration : IConfiguration
    {
        public string ValidIndicator =>
            ConfigurationManager.AppSettings["ValidIndicator"] ?? string.Empty;

        public string InvalidIndicator =>
            ConfigurationManager.AppSettings["InvalidIndicator"] ?? string.Empty;

        public string InvalidLineFormatIndicator =>
            ConfigurationManager.AppSettings["InvalidLineFormatIndicator"] ?? string.Empty;

        public bool IgnoreInvalidLinesIndicator =>
            ConfigurationManager.AppSettings["IgnoreInvalidLinesIndicator"]?.Equals("true", StringComparison.OrdinalIgnoreCase) ?? false;
    }
}
