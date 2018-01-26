using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExamples.Loggers
{
    public class ConsoleLogger : IGoodLogger
    {
        public void Log(string msg)
        {
            Console.WriteLine($"Logging to console: {msg}");
        }
    }
}
