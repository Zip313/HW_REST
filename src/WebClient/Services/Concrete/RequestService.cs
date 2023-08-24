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
    public class RequestService
    {
        HttpClient httpClient;
        public IMethodStrategy methodStrategy;
        public RequestService(string baseAddress, IMethodStrategy methodStrategy)
        {
            this.httpClient = new HttpClient() { BaseAddress = new Uri(baseAddress) };
            this.methodStrategy = methodStrategy;
        }

        public async Task<T> SendRequestAsync<T>(string uri,object body=null)
        {
            var response = await methodStrategy.Send(this.httpClient, uri, body);
            if (!response.IsSuccessStatusCode) throw new HttpRequestException(await response.Content.ReadAsStringAsync());
            T content = await response.Content.ReadFromJsonAsync<T>();
            return content;
        }

    }
}
