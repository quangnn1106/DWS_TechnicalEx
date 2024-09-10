using ManipulateLines.Manipulations;
using ManipulateLines.Services;

class Program
{
    static async Task Main(string[] args)
    {
        string inputFile = "./Input/input.txt";
        string sortedFile = "./Output/sorted.txt";
        string reversedFile = "./Output/reversed.txt";
        string encryptedFile = "./Output/encrypted.txt";
        string lengthFile = "./Output/lengths.txt";

        var fileHandler = new FileHandler();
        var manipulationService = new ManipulationService(fileHandler);
        var sortFileResult = File.ReadAllText(sortedFile);
        // Apply different manipulations
        await manipulationService.ApplyManipulationAsync(inputFile, sortedFile, new SortLines());
        Console.WriteLine($"Sorted lines written to\n{sortFileResult}");

        var reversedFileResult = File.ReadAllText(reversedFile);
        await manipulationService.ApplyManipulationAsync(inputFile, reversedFile, new ReverseLines());
        Console.WriteLine($"Reversed lines written to {reversedFileResult}");

        var encryptedFileResult = File.ReadAllText(encryptedFile);
        await manipulationService.ApplyManipulationAsync(inputFile, encryptedFile, new EncryptLines());
        Console.WriteLine($"Encrypted lines written to {encryptedFileResult}");

        var lengthFileResult = File.ReadAllText(lengthFile);
        await manipulationService.ApplyManipulationAsync(inputFile, lengthFile, new CalculateLineLengths());
        Console.WriteLine($"Lines with lengths written to {lengthFile}");
    }
}