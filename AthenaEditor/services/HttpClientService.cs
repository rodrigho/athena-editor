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
using System.Threading;

namespace AthenaEditor.controllers
{
    class HttpClientService
    {
        private static readonly HttpClient httpClient;
        private static HttpClientService httpClientService;

        static HttpClientService()
        {
            httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromMinutes(60);
        }

        public HttpClientService GetInstance()
        {
            if (httpClientService == null)
                httpClientService = new HttpClientService();
            return httpClientService;
        }

        private static async Task<Response> _Post(String body, String url)
        {
            Response response = null;
            using (var content = new StringContent(body, Encoding.UTF8, "application/json"))
            {
                HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(url, content);                
                Console.WriteLine(HttpStatusCode.Created);

                string returnValue = httpResponseMessage.Content.ReadAsStringAsync().Result;

                Response result = JsonConvert.DeserializeObject<Response>(returnValue);
                response = JsonConvert.DeserializeObject<Response>(returnValue);                
            }
            return response;
        }

        private static Response _Post2(String body, String url)
        {
            Response response = null;
            using (var content = new StringContent(body, Encoding.UTF8, "application/json"))
            {
                HttpResponseMessage httpResponseMessage = httpClient.PostAsync(url, content).Result;
                Console.WriteLine(HttpStatusCode.Created);

                string returnValue = httpResponseMessage.Content.ReadAsStringAsync().Result;

                Response result = JsonConvert.DeserializeObject<Response>(returnValue);
                response = JsonConvert.DeserializeObject<Response>(returnValue);
            }
            return response;
        }


        public static Response Post(String body, String url, bool useAsync = true)
        {
            Response response;
            try
            {
                response = useAsync? _Post(body, url).Result : _Post2(body, url);                
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Error API: {0}", ex.Message), ex.InnerException);
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
