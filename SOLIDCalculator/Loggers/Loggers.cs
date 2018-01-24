using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOLIDCalculator.Loggers
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            using (var file = new System.IO.StreamWriter(@"C:\Temp\AreaLog.txt"))
            {
                file.WriteLine(message);
            }
        }
    }

    public class MessageBoxLogger : ILogger
    {
        public void Log(string message)
        {
            MessageBox.Show(message);
        }

        public double divide(double x, double y)
        {
        }
    }
}
