using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Manipulations
{
    public class ReverseLettersInLines : ITextManipulation
    {
        public string[] Manipulate(string[] lines)
        {
            return lines.Select(line => new string(line.Reverse().ToArray())).ToArray();
        }
    }
}
