using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Manipulations
{
    public class FileHandler : IFileHandler
    {
        public async Task<string[]> ReadFileAsync(string filePath)
        {
            return await File.ReadAllLinesAsync(filePath);
        }

        public async Task WriteFileAsync(string filePath, string[] lines)
        {
            await File.WriteAllLinesAsync(filePath, lines);
        }
    }
}
