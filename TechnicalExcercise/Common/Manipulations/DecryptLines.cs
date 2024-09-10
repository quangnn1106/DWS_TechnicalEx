using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Manipulations
{
    public class DecryptLines : ITextManipulation
    {
        public string[] Manipulate(string[] lines)
        {
            return lines.Select(DecryptLine).ToArray();
        }

        private string DecryptLine(string line)
        {
            return new string(line.Select(ch => (char)(ch - 20)).ToArray());
        }
    }
}
