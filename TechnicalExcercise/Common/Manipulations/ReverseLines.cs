using Common.Interface;

namespace Common.Manipulations
{
    public class ReverseLines: ITextManipulation
    {
        public string[] Manipulate(string[] lines)
        {
            try
            {
                return lines.Reverse().ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reversing lines: {ex.Message}");
                throw;
            }
        }

    }
}
