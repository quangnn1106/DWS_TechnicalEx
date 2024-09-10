using ManipulateLines.Manipulations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ManipulateLines.Services
{
    public class ManipulationService
    {
        private readonly FileHandler _fileHandler;

        public ManipulationService(FileHandler fileHandler)
        {
            _fileHandler = fileHandler;
        }

        public async Task ApplyManipulationAsync(string inputFile, string outputFile, ITextManipulation manipulation)
        {
            var lines = await _fileHandler.ReadFileAsync(inputFile);
            var manipulatedLines = manipulation.Manipulate(lines);
            await _fileHandler.WriteFileAsync(outputFile, manipulatedLines);
        }
    }
}
