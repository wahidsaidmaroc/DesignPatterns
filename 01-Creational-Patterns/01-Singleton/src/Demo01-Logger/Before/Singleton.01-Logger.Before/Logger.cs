namespace Singleton._01_Logger.Before;

public class Logger
{
    private static int _counter = 0;

    public Logger()
    {
        _counter++;

        Console.WriteLine(
            $"Logger Instance Created : {_counter}"
        );
    }

    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}
