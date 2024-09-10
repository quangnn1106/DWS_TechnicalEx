using Common.Manipulations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Services
{
    public class ManipulationService: IManipulationService
    {
        private readonly IFileHandler _fileHandler;

        public ManipulationService(IFileHandler fileHandler)
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
