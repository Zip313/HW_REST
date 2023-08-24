using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebClient.Services.Interfaces;

namespace WebClient.Services.Concrete
{
    public class GetMethodStrategy : IMethodStrategy
    {
        public async Task<HttpResponseMessage> Send(HttpClient httpClient, string uri, object body = null)
        {
            var req = await httpClient.GetAsync(uri);
            return req;
        }
    }
}
