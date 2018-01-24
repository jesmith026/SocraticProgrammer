using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using SOLIDCalculator.Loggers;
using SOLIDCalculator.Models;

namespace SOLIDCalculator.Calculators
{
    public class AreaCalculator
    {
        private readonly ILogger _logger;

        public AreaCalculator(ILogger logger)
        {
            _logger = logger;
        }

        public double CalculateTotalAreaOfCollection(IEnumerable<Rectangle> rectangles)
        {
            var totalArea = rectangles.Sum(x => x.Length * x.Width);
            
            _logger.Log($"Total area of collection is {totalArea}");

            return totalArea;
        }
        
    }
}
