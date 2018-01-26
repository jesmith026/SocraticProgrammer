using System;

namespace SOLIDExamples.Loggers
{
    public enum LogType
    {
        File,
        Db,
        EventViewer,
        Console
    }

    public class BadLogger
    {
        public void Log(LogType logType, string msg)
        {
            switch (logType)
            {
                case LogType.File:
                    Console.WriteLine($"Logging to file: {msg}");
                    break;
                case LogType.Db:
                    Console.WriteLine($"Logging to DB: {msg}");
                    break;
                case LogType.EventViewer:
                    Console.WriteLine($"Logging to Event Viewer: {msg}");
                    break;
                case LogType.Console:
                    Console.WriteLine($"Logging to Console: {msg}");
                    break;
                default:
                    Console.WriteLine($"Logger type is unidentifiable");
                    break;
            }
        }
    }
}
