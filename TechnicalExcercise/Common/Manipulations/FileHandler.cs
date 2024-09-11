using Common.Interface;

namespace Common.Manipulations
{
    public class FileHandler : IFileHandler
    {
        public async Task<string[]> ReadFileAsync(string filePath)
        {
            try
            {
                return await File.ReadAllLinesAsync(filePath);
            }
            catch (Exception ex)
            {
                // Handle or log the exception as needed
                Console.WriteLine($"Error reading file: {ex.Message}");
                return Array.Empty<string>();
            }
        }

        public async Task WriteFileAsync(string filePath, string[] lines)
        {
            try
            {
                await File.WriteAllLinesAsync(filePath, lines);
            }
            catch (Exception ex)
            {
                // Handle or log the exception as needed
                Console.WriteLine($"Error writing file: {ex.Message}");
            }
        }
    }
}
