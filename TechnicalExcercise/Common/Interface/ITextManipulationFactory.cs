namespace Common.Interface
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
