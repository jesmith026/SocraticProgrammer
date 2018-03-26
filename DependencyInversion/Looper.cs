using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInversion.Loggers;

namespace DependencyInversion
{
    public class Looper
    {
        private readonly ILogger _logger;

        public Looper(ILogger logger)
        {
            _logger = logger;
        }

        public void Loop(int limit)
        {
            for (var i = 0; i < limit; i++)
            {
                _logger.Write(i.ToString());
            }
        }
    }
}
