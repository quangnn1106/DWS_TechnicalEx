using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Common.Interface;

namespace Common.Services
{
    public class RandomService : IRandomService
    {
        private readonly Random _random = new Random();
        public int GetRandomNumber(int min, int max)
        {
            return _random.Next(min, max + 1); // Including max
        }

        public string GetRandomWord(string filePath)
        {
            try
            {
                // Read all the text from the file
                string fileContent = File.ReadAllText(filePath);

                if (string.IsNullOrWhiteSpace(fileContent))
                {
                    throw new Exception("The file is empty or contains only whitespace.");
                }

                // Define a regex pattern to match words 
                string pattern = @"\b[\w'-]+\b";

                // Use Regex to find all words in the file
                MatchCollection matches = Regex.Matches(fileContent, pattern);
      
                if (matches.Count == 0)
                {
                    throw new Exception("No words found in the file.");
                }

                // Generate a random index
                Random random = new();
                int randomIndex = random.Next(matches.Count);

                // Return the random word
                return matches[randomIndex].Value;
            }
            catch (FileNotFoundException ex)
            {
                // Handle file not found exception
                Console.WriteLine(ex.Message);
                return "File not found.";
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                Console.WriteLine($"An error occurred: {ex.Message}");
                return "An error occurred while processing the file.";
            }
       
    }
    }

}
