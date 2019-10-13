using System.Collections.Generic;
using System.IO;

namespace EnrollmentManager.Business
{
    public class EnrollmentFileValidator
    {
        private readonly IFullEnrollmentNumberValidator _validator;

        public EnrollmentFileValidator(IFullEnrollmentNumberValidator validator)
        {
            _validator = validator;
        }

        public void Validate(string inputFilePath, string outputFilePath, string validIndicator = "Valid", string invalidIndicator = "Invalid")
        {
            var inputLines = File.ReadAllLines(inputFilePath);
            var outputLines = new List<string>();

            foreach (string line in inputLines)
            {
                string indicator = _validator.Validate(line)
                    ? validIndicator
                    : invalidIndicator;

                outputLines.Add($"{line} {indicator}");
            }

            File.WriteAllLines(outputFilePath, outputLines);
        }
    }
}
