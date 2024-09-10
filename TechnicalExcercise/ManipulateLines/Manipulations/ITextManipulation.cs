using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateLines.Manipulations
{
    public interface ITextManipulation
    {
        string[] Manipulate(string[] lines);
    }
}
