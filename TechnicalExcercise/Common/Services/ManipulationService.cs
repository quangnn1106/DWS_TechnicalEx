using Common.Interface;
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
            try
            {
                // Attempt to read the input file
                var lines = await _fileHandler.ReadFileAsync(inputFile);

                // Perform the manipulation on the lines
                var manipulatedLines = manipulation.Manipulate(lines);

                // Attempt to write the manipulated lines to the output file
                await _fileHandler.WriteFileAsync(outputFile, manipulatedLines);
            }
            catch (FileNotFoundException ex)  // Handle file not found exception
            {
                // Log or handle the file not found case
                Console.WriteLine($"File not found: {ex.Message}");
                throw;  // Optionally rethrow the exception to propagate it further
            }
            catch (IOException ex)  // Handle general IO exceptions
            {
                // Log or handle IO errors
                Console.WriteLine($"IO error while processing files: {ex.Message}");
                throw;  // Optionally rethrow the exception
            }
            catch (Exception ex)  // Catch any other types of exceptions
            {
                // Log or handle general exceptions
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;  // Optionally rethrow the exception
            }
        }
    }
}
