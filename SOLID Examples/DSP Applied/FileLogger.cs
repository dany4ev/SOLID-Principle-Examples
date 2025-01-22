namespace SOLID_Examples.DSP_Applied;

public class FileLogger : ILogger
{
    private string _filePath;
    public FileLogger(string filePath)
    {
        _filePath = filePath;
    }
    public void LogMessage(string message)
    {
        // Just a simple example. In a real-world scenario, proper exception handling and file IO management is needed.
        File.AppendAllText(_filePath, message);
    }
}