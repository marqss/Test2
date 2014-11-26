using Calculator.BusinessInterfaces;
using Calculator.DataAccessInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BusinessLayer
{
    public class Calculator : ICalculatorLogic
    {
        private IRepository _repository;

        public Calculator(IRepository repository)
        {
            _repository = repository;
        }

        public int AddTwoInts(int x, int y)
        {
            int result = x+y;
            ProcessDBOperation(
                () =>
                {
                    _repository.StoreOperation("X+Y= " + result);
                });

            return result;
        }

        private bool ProcessDBOperation(Action act)
        {
            // add some logging
            try
            {
                act.Invoke();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
