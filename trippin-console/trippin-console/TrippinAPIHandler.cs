using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace trippin_console
{
    internal class TrippinAPIHandler : IAPIHandler
    {
        private static HttpClient HttpClient = new HttpClient()
        {
            BaseAddress = new Uri("https://services.odata.org/TripPinRESTierService/(S(1iit5imcudlfb3hd1duwtznk))/")
        };

        public async Task<HttpResponseMessage> Get(string argument)
        {
            try
            {
                var response = await HttpClient.GetAsync(argument);
                response.EnsureSuccessStatusCode();
                return response;
            }
            catch (HttpRequestException)
            {
                return null;
            }
            
        }

        public async Task<HttpResponseMessage> Post(string argument, HttpContent httpContent)
        {
            try
            {
                var response = await HttpClient.PostAsync(argument, httpContent);
                response.EnsureSuccessStatusCode();
                return response;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
