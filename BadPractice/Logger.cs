using System;
using System.Windows.Forms;

namespace BadPractice
{
    public class Logger
    {
        private LogType _type;

        public Logger(LogType logType)
        {
            _type = logType;
        }

        public void Write(string msg)
        {
            switch (_type)
            {
                case LogType.Console:
                    Console.WriteLine(DateTime.Now.ToString("MMddyyyyhhmmss: ") + msg);
                    break;
                case LogType.Window:
                    MessageBox.Show(DateTime.Now.ToString("MMddyyyyhhmmss: ") + msg);
                    break;
                default:
                    throw new Exception("Log Type Not Found.");
            }
        }
    }
}
