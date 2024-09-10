using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Manipulations
{
    public class CalculateLineLengths : ITextManipulation
    {
        public string[] Manipulate(string[] lines)
        {
            return lines.Select(line => $"{line.Length} {line}").ToArray();
        }
    }
}
