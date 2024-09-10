using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Manipulations
{
    public interface IFileHandler
    {
        Task<string[]> ReadFileAsync(string path);
        Task WriteFileAsync(string path, string[] lines);
    }

}
