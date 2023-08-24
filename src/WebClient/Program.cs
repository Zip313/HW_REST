using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WebClient.Services.Concrete;

namespace WebClient
{
    static class Program
    {
        static void Main(string[] args)
        {
            
            CustomerCreateRequest customerCreateRequest = RandomCustomer();
            CustomerService customerService = new CustomerService();
            Console.WriteLine("Пробуем создать Иванова Ивана Id=1") ;
            string msg = customerService.CreateCustomer(customerCreateRequest).Result;
            Console.WriteLine(msg);
            Console.WriteLine("Повторно пробуем создать Иванова Ивана Id=1");
            msg = customerService.CreateCustomer(customerCreateRequest).Result;
            Console.WriteLine(msg);
            while (true)
            {
                Console.WriteLine("Пробуем извлечь пользователя по Id, собственно введите Id");
                long id = long.Parse(Console.ReadLine());
                msg = customerService.ReadCustomer(id).Result;
                Console.WriteLine(msg);
            }
            



            Console.ReadLine();
        }

        private static CustomerCreateRequest RandomCustomer()
        {
            return new CustomerCreateRequest(1,"Иван", "Иванов");
        }

        
    }
}