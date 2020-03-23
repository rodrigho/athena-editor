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
                Console.WriteLine(HttpStatusCode.Created);

                string returnValue = httpResponseMessage.Content.ReadAsStringAsync().Result;

                response = JsonConvert.DeserializeObject<Response>(returnValue);
            }
            return response;
        }

        public static async Task Post(String body, String url, DataGridView dataGridViewResult, TabControl tabControl, HashSet<String> queryExecutionIds)
        {
            Response response = Post(body, url);

            TabPage tabPage = tabControl.TabPages[0];
            tabPage.Text = String.Format("Result #{0} ({1}x{2})", 1, response.Lists[0].Count, response.Lists.Count - 1);

            dataGridViewResult.Columns.Clear();
            foreach (String header in response.Lists[0])
                dataGridViewResult.Columns.Add(header, header.Replace(" ", "_"));
            for (int i = 0; i < response.Lists.Count - 1; i++)
                dataGridViewResult.Rows.Insert(i, response.Lists[i + 1].ToArray());

            queryExecutionIds.Add(response.QueryExecutionId);
            Console.WriteLine("QueryExecutionId: " + response.QueryExecutionId);

        }

        public static async Task Get(String url)
        {
            var responseString = await httpClient.GetStringAsync(url);
            Console.WriteLine(responseString);
        }
    }
}
