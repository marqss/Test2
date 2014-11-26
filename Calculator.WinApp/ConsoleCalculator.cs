using Calculator.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.WinApp
{
    public class ConsoleCalculator
    {
        private ICalculator _calculatorService;

        public ConsoleCalculator(ICalculator calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public void Start()
        {
            Console.WriteLine("Started");

            Console.ReadLine();

            _calculatorService.Add(10, 15);

            return;
        }
    }
}
