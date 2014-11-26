using Calculator.BusinessInterfaces;
using Calculator.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.LocalService
{
    public class LocalCalculatorService : ICalculator
    {
        private ICalculatorLogic _businessModel;

        public LocalCalculatorService(ICalculatorLogic businessModel)
        {
            _businessModel = businessModel;
        }

        public int Add(int x, int y)
        {
            var result = _businessModel.AddTwoInts(x, y);
            return x + result;
        }

        public int Sub(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
