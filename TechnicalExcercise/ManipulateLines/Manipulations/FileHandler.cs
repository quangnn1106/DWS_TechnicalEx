using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateLines.Manipulations
{
    public class FileHandler
    {
        public async Task<string[]> ReadFileAsync(string filePath)
        {
            return await File.ReadAllLinesAsync(filePath);
        }

        public string ReadAllText(string filePath)
        {
            // read and return all lines from file
            return File.ReadAllText(filePath);
        }


        public async Task WriteFileAsync(string filePath, string[] lines)
        {
            await File.WriteAllLinesAsync(filePath, lines);
        }
    }
}
