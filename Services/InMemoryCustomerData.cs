using CustomerOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerOrder.Services
{
    public class InMemoryCustomerData : ICustomerData
    {
        public InMemoryCustomerData()
        {
            _customers = new List<Customer>
            {
                new Customer { ID = 1, Name = "Ion" },
                new Customer { ID = 2, Name = "Vasile" },
                new Customer { ID = 3, Name = "Camil" }
            };
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customers.OrderBy(r=>r.Name);
        }

        List<Customer> _customers;
    }
}
