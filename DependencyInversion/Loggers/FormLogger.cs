using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DependencyInversion.Loggers
{
    public class FormLogger : ILogger
    {
        public void Write(string message)
        {
            MessageBox.Show(DateTime.Now.ToString("MMddyyyyhhmmss: ") + message);
        }
    }
}
