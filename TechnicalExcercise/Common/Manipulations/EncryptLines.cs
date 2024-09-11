using Common.Interface;

namespace Common.Manipulations
{
    public class EncryptLines : ITextManipulation
    {
        public string[] Manipulate(string[] lines)
        {
            try
            {
                return lines.Select(EncryptLine).ToArray();
            }
            catch (Exception ex)
            {
                // Handle or log the exception as needed
                Console.WriteLine($"Error during encryption: {ex.Message}");
                return Array.Empty<string>();
            }
        }

        private string EncryptLine(string line)
        {
            try
            {
                return new string(line.Select(ch => EncryptChar(ch)).ToArray());
            }
            catch (Exception ex)
            {
                // Handle or log the exception as needed
                Console.WriteLine($"Error encrypting line: {ex.Message}");
                return string.Empty;
            }
        }

        private char EncryptChar(char ch)
        {
            try
            {
                // Add 20 to the ASCII value of the character and handle overflow
                int encryptedValue = ch + 20;
                if (encryptedValue > char.MaxValue)
                {
                    encryptedValue -= char.MaxValue + 1;
                }
                return (char)encryptedValue;
            }
            catch (Exception ex)
            {
                // Handle or log the exception as needed
                Console.WriteLine($"Error encrypting character: {ex.Message}");
                return '\0'; // Return null character in case of error
            }
        }
    }
}
