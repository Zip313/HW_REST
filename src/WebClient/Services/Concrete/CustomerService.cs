using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient.Services.Concrete
{
    public class CustomerService
    {
        RequestService requestService;
        public CustomerService()
        {
            //имитируем DI
            Uri baseUri = new Uri(@"https://localhost:5001/customers");
            requestService = new RequestService(@"https://localhost:5001", new PostMethodStrategy());
        }

        public async Task<string> CreateCustomer(CustomerCreateRequest createRequest)
        {
            try
            {
                this.requestService.methodStrategy = new PostMethodStrategy();
                long newCustomerId = await requestService.SendRequestAsync<long>("customers", createRequest);
                return $"Пользователь создан, Id = {newCustomerId} \r\n";
            } catch (Exception ex)
            {
                return ex.Message + "\r\n";
            }
            
        }

        public async Task<string> ReadCustomer(long id)
        {
            try
            {
                this.requestService.methodStrategy = new GetMethodStrategy();
                Customer customer = await requestService.SendRequestAsync<Customer>($"customers/{id}");
                return $"Пользователь прочитан, Id = {customer.Id}, lastName = {customer.Lastname}, firstName = {customer.Firstname} \r\n";
            }
            catch (Exception ex)
            {
                return ex.Message+ "\r\n";
            }

        }
    }
}
