using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interface
{
    public interface IRandomService
    {
        int GetRandomNumber(int min, int max);
        string GetRandomWord(string filePath);
    }

}
