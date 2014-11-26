using Calculator.ServiceInterfaces;
using Calculator.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.WinApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = DependencyResolver.GetInstance().ResolveObject<ConsoleCalculator>();
            calculator.Start();
        }
    }
}
