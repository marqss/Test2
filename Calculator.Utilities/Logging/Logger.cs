using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Utilities.Logging
{
    public class Logger : ILogger
    {
        private NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        public void LogError(string message)
        {
            _logger.Error(message);    
        }
    }
}
