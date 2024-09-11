namespace Common.Interface
{
    public interface IManipulationService
    {
        Task ApplyManipulationAsync(string inputFile, string outputFile, ITextManipulation manipulation);
    }
}
