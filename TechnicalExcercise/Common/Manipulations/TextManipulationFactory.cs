using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Manipulations
{
    public class TextManipulationFactory : ITextManipulationFactory
    {
        public ITextManipulation CreateSortLines() => new SortLines();
        public ITextManipulation CreateReverseLines() => new ReverseLines();
        public ITextManipulation CreateEncryptLines() => new EncryptLines();
        public ITextManipulation CreateCalculateLineLengths() => new CalculateLineLengths();

        public ITextManipulation CreateSortLinesRandomly() => new SortLinesRandomly();

        public ITextManipulation CreateReverseLetter() => new ReverseLettersInLines();

        public ITextManipulation CreateDecryptLines() => new DecryptLines();

    }

}
