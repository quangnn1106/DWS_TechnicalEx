using Common.Interface;

namespace Common.Manipulations
{
    public class SortLinesRandomly : ITextManipulation
    {
        private static Random _random = new Random();

        public string[] Manipulate(string[] lines)
        {
            try
            {
                return lines.OrderBy(line => _random.Next()).ToArray();
            }
            catch (Exception ex)
            {
                // Handle or log the exception as needed
                Console.WriteLine($"Error during sorting: {ex.Message}");
                return Array.Empty<string>();
            }
        }
    }
}
