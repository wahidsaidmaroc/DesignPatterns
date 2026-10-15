using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton._01_Logger.After;

public sealed class Logger
{
    private static readonly Lazy<Logger> _instance =
        new(() => new Logger());

    private Logger()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(
            "Single Logger Instance Created");
        Console.ResetColor();
    }

    public static Logger Instance
    {
        get { return _instance.Value; }
    }

    public void Log(string source, string message)
    {
        Console.WriteLine(
            $"[{DateTime.Now:HH:mm:ss}] " +
            $"[{source}] {message}");
    }
}
