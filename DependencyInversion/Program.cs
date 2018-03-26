using System;
using DependencyInversion.Loggers;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleLogger = new ConsoleLogger();
            var looper = new Looper(consoleLogger);

            looper.Loop(10);

            Console.WriteLine("...................\n");

            var formLogger = new FormLogger();
            looper = new Looper(formLogger);
            looper.Loop(1);
        }
    }
}
