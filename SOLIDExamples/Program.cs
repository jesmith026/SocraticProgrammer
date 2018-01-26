using System;

namespace SOLIDExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTesting the bad logger....\n");
            BadLoggerTester.Test();

            Console.WriteLine("\n\nTesting the good logger....\n");
            GoodLoggerTester.Test();

            Console.WriteLine();
        }
    }
}
