using System.Collections.Generic;
using System.IO;

namespace EnrollmentManager.Business
{
    public class EnrollmentFileGenerator
    {
        private readonly IFullEnrollmentNumberGenerator _generator;

        public EnrollmentFileGenerator(IFullEnrollmentNumberGenerator generator)
        {
            _generator = generator;
        }

        public void Validate(string inputFilePath, string outputFilePath, string invalidInputLineIndicador)
        {
            var inputLines = File.ReadAllLines(inputFilePath);
            var outputLines = new List<string>();

            foreach (string line in inputLines)
            {
                string outputLine;
                try
                {
                    outputLine = _generator.Generate(line);

                }
                catch
                {
                    outputLine = $"{invalidInputLineIndicador} ({line})";
                }

                outputLines.Add(outputLine);
            }

            File.WriteAllLines(outputFilePath, outputLines);
        }
    }
}
