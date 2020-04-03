using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using AthenaEditor.entities;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace AthenaEditor.controllers
{
    class HttpClientService
    {
        private static readonly HttpClient httpClient;
        private static HttpClientService httpClientService;

        static HttpClientService()
        {
            httpClient = new HttpClient();
        }

        public HttpClientService GetInstance()
        {
            if (httpClientService == null)
                httpClientService = new HttpClientService();
            return httpClientService;
        }

        public static Response Post(String body, String url)
        {
            Response response;
            using (var content = new StringContent(body, Encoding.UTF8, "application/json"))
            {
                HttpResponseMessage httpResponseMessage = httpClient.PostAsync(url, content).Result;                

                string returnValue = httpResponseMessage.Content.ReadAsStringAsync().Result;

                response = JsonConvert.DeserializeObject<Response>(returnValue);
            }
            return response;
        }               

        public static async Task Get(String url)
        {
            var responseString = await httpClient.GetStringAsync(url);
            Console.WriteLine(responseString);
        }
    }
}
