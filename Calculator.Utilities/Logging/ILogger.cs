﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Utilities.Logging
{
    public interface ILogger
    {
        void LogError(string message);
    }
}
