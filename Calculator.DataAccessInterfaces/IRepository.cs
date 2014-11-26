using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.DataAccessInterfaces
{
    public interface IRepository
    {
        bool StoreOperation(string description);
    }
}
