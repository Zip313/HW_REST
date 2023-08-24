using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using WebApi.Models;

namespace WebApi.Services
{
    public interface ICustomerService
    {
        Task<Customer> GetCustomerAsync(long id);
        Task<long> CreateCustomerAsync(Customer customer);
       
    }
}
