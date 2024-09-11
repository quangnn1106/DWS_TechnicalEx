using Common.Interface;

namespace Common.Manipulations
{
    public class SortLines : ITextManipulation
    {
        public string[] Manipulate(string[] lines)
        {
            try
            {
                return lines.OrderBy(line => line).ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while sorting lines: {ex.Message}");
                throw;
            }
        }
    }
}
