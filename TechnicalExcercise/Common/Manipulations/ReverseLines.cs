using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Manipulations
{
    public class ReverseLines: ITextManipulation
    {
        public string[] Manipulate(string[] lines)
        {
            return lines.Reverse().ToArray();
        }

    }
}
