using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Manipulations
{
    public interface ITextManipulationFactory
    {
        ITextManipulation CreateSortLines();
        ITextManipulation CreateReverseLines();
        ITextManipulation CreateEncryptLines();
        ITextManipulation CreateCalculateLineLengths();

        // fun
        ITextManipulation CreateSortLinesRandomly();
        ITextManipulation CreateReverseLetter();
        ITextManipulation CreateDecryptLines();

    }
}
