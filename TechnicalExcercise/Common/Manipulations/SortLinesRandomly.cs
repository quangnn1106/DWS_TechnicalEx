using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Manipulations
{
    public class SortLinesRandomly : ITextManipulation
    {
        private static Random _random = new Random();

        public string[] Manipulate(string[] lines)
        {
            return lines.OrderBy(line => _random.Next()).ToArray();
        }
    }
}
