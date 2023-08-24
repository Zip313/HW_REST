using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WebClient.Services.Interfaces;

namespace WebClient.Services.Concrete
{
    public class PostMethodStrategy : IMethodStrategy
    {
        public async Task<HttpResponseMessage> Send(HttpClient httpClient, string uri, object body)
        {
            JsonContent content = JsonContent.Create(body);
            var req = await httpClient.PostAsync(uri, content);
            return req;
        }
    }
}
