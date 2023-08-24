using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Services
{
    public class CustomerService : ICustomerService
    {
        List<Customer> customers= new List<Customer>();

        public async Task<Customer> GetCustomerAsync(long id)
        {
            var customer = this.customers.Where(x => x.Id == id).FirstOrDefault();
            if (customer == null) throw new KeyNotFoundException("Клиента с таким Id не существует");
            return customer;
        }

        public async Task<long> CreateCustomerAsync(Customer customer)
        {
            if (customers.Any(x => x.Id == customer.Id)) throw new ArgumentException("Клиент с таким Id уже существует");
            this.customers.Add(customer);
            return customer.Id;
        }
    }
}
