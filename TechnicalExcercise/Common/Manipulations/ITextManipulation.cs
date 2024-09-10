using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Manipulations
{
    public interface ITextManipulation
    {
        string[] Manipulate(string[] lines);
    }
}
