namespace Common.Interface
{
    public interface IFileHandler
    {
        Task<string[]> ReadFileAsync(string path);
        Task WriteFileAsync(string path, string[] lines);
    }
}
 