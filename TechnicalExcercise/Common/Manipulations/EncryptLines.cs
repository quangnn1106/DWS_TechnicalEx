using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Manipulations
{
    public class EncryptLines : ITextManipulation
    {
        public string[] Manipulate(string[] lines)
        {
            return lines.Select(EncryptLine).ToArray();
        }

        private string EncryptLine(string line)
        {
            return new string(line.Select(ch => (char)(ch + 20)).ToArray());
        }
    }
}
