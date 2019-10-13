using System.Collections.Generic;
using System.IO;

namespace EnrollmentManager.Business
{
    public interface IEnrollmentFileGenerator
    {
        void Generate(string inputFilePath, string outputFilePath, bool ignoreInvalidLineInputs = false, string invalidInputLineIndicador = "Invalid Input");
    }

    public class EnrollmentFileGenerator : IEnrollmentFileGenerator
    {
        private readonly IFullEnrollmentNumberGenerator _generator;

        public EnrollmentFileGenerator(IFullEnrollmentNumberGenerator generator)
        {
            _generator = generator;
        }

        public void Generate(string inputFilePath, string outputFilePath, bool ignoreInvalidLineInputs = false, string invalidInputLineIndicador = "Invalid Input")
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
                    if (ignoreInvalidLineInputs)
                        continue;

                    outputLine = $"{invalidInputLineIndicador} ({line})";
                }

                outputLines.Add(outputLine);
            }

            File.WriteAllLines(outputFilePath, outputLines);
        }
    }
}
