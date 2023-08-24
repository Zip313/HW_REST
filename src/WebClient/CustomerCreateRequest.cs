using System;
using System.Net.Http;

namespace WebClient
{
    public class CustomerCreateRequest
    {
        
        public CustomerCreateRequest()
        {
        }

        public CustomerCreateRequest(
            long id,
            string firstName,
            string lastName)
        {
            Id = id; //непонятно по заданию кто должен отправлять Id, так как в задаче написано что сервер должен отправлять ошибку если ИД уже есть, значит мы должны отправлять ид с клиента
            Firstname = firstName;
            Lastname = lastName;
        }

        public long Id { get; init; }
        public string Firstname { get; init; }

        public string Lastname { get; init; }
    }
}