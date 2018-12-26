using CustomerOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerOrder.Services
{
    public interface ICustomerData
    {
        IEnumerable<Customer> GetAll();
    }
}
