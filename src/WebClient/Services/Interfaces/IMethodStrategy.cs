using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebClient.Services.Interfaces
{
    public interface IMethodStrategy
    {
        Task<HttpResponseMessage> Send(HttpClient httpClient, string uri, object body);
    }
}
