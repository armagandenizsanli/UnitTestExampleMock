using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Entity;

namespace UnitTestExample.Repository
{
    public class CustomerRepository : IRepository
    {
        virtual public bool Add(Customer customer)
        {
            return true;
        }
    }
}
