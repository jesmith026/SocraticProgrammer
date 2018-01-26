using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExamples.Loggers
{
    public class FileLogger : IGoodLogger
    {
        public void Log(string msg)
        {
            Console.WriteLine($"Logging to File: {msg}");
        }
    }
}
