using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var words = File.ReadAllLines(filePath);
            return words[_random.Next(words.Length)];
        }
    }

}
