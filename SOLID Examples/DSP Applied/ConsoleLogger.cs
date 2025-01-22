namespace SOLID_Examples.DSP_Applied;

public class ConsoleLogger : ILogger
{
    public void LogMessage(string message)
    {
        Console.WriteLine(message);
    }
}