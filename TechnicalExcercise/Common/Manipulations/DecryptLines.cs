using Common.Interface;

namespace Common.Manipulations
{
    public class DecryptLines : ITextManipulation
    {
        public string[] Manipulate(string[] lines)
        {
            try
            {
                return lines.Select(DecryptLine).ToArray();
            }
            catch (Exception ex)
            {
                // Handle or log the exception as needed
                Console.WriteLine($"Error during decryption: {ex.Message}");
                return Array.Empty<string>();
            }
        }

        private string DecryptLine(string line)
        {
            try
            {
                return new string(line.Select(ch => DecryptChar(ch)).ToArray());
            }
            catch (Exception ex)
            {
                // Handle or log the exception as needed
                Console.WriteLine($"Error decrypting line: {ex.Message}");
                return string.Empty;
            }
        }

        private char DecryptChar(char ch)
        {
            try
            {
                // Subtract 20 from the ASCII value of the character and handle underflow
                int decryptedValue = ch - 20;
                if (decryptedValue < char.MinValue)
                {
                    decryptedValue += char.MaxValue + 1;
                }
                return (char)decryptedValue;
            }
            catch (Exception ex)
            {
                // Handle or log the exception as needed
                Console.WriteLine($"Error decrypting character: {ex.Message}");
                return '\0'; // Return null character in case of error
            }
        }
    }
}
