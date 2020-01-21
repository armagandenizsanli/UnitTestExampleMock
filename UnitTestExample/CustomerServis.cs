using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Entity;
using UnitTestExample.Repository;

namespace UnitTestExample
{
    public class CustomerServis
    {
        private readonly CustomerRepository _customerRepository;
        public CustomerServis(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public string Add(Customer customer)
        {
            var result= _customerRepository.Add(customer);
            if(result)
            {
                return "ok";
            }else
            {
                return "fail";
            }
        }
    }
}
