using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Manipulations
{
    public class SortLines : ITextManipulation
    {
        public string[] Manipulate(string[] lines)
        {
            return lines.OrderBy(line => line).ToArray();
        }
    }
}
