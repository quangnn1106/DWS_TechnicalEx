using Common.Interface;

namespace Common.Manipulations
{
    public class ReverseLettersInLines : ITextManipulation
    {
        public string[] Manipulate(string[] lines)
        {
            try
            {
                return lines.Select(line => new string(line.Reverse().ToArray())).ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reversing lines: {ex.Message}");
                throw;
            }
        }
    }
}
