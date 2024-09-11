using Common.Interface;

namespace Common.Manipulations
{
    public class CalculateLineLengths : ITextManipulation
    {
        public string[] Manipulate(string[] lines)
        {
            try
            {
                return lines.Select(line => $"{line.Length} {line}").ToArray();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while calculating line lengths: {ex.Message}");
                throw;
            }
        }
    }
}
