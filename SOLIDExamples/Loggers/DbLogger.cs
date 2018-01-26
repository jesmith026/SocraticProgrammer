﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExamples.Loggers
{
    public class DbLogger : IGoodLogger
    {
        public void Log(string msg)
        {
            Console.WriteLine($"Logging to DB {msg}");
        }
    }
}
