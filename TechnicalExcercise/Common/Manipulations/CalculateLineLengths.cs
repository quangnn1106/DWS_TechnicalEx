using Common.Interface;

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
