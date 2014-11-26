using Calculator.DataAccessInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.DataAccess
{
    public class DBAccess : IRepository
    {
        public bool StoreOperation(string description)
        {
            Database1Entities ent = new Database1Entities();
            ent.Operation.Add(new Operation() { Desc = description });
            ent.SaveChanges();
            return true;
        }
    }
}
