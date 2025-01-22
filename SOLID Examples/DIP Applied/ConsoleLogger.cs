namespace SOLID_Examples.DIP_Applied;

public class ConsoleLogger : ILogger
{
    public void LogMessage(string message)
    {
        Console.WriteLine(message);
    }
}