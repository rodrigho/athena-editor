using AthenaEditor.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AthenaEditor.controllers
{
    class MainController
    {
        public HashSet<string> QueryExecutionIds { get; set; }
        public Config CurrentConfig { get; set; }
        private static readonly HttpClient httpClient = new HttpClient();
        public MainController()
        {
            CurrentConfig = new Config(
                "database", 
                "s3-output",
                1000,
                "accessKey",
                "secretKey",
                "region");
            QueryExecutionIds = new HashSet<string>();
        }

        public void ExecuteCurrent(String query, bool useQueryId, String queryExecutionId, DataGridView dataGridViewResult, TabControl tabControl)
        {
            CurrentConfig.queries.Clear();
            CurrentConfig.queries.Add(query);
            CurrentConfig.useQueryId = useQueryId;
            CurrentConfig.queryExecutionId = queryExecutionId;
            HttpClientService.Post(JsonConvert.SerializeObject(CurrentConfig), "http://127.0.0.1:8081/athena-api/execute", 
                dataGridViewResult, tabControl, QueryExecutionIds);
        }

        public async void Salute()
        {
            Uri uri = new Uri("http://127.0.0.1:8081/athena-api/");
            var responseString = await httpClient.GetStringAsync(uri).ConfigureAwait(false);
            Console.WriteLine(responseString);
        }

    }
}
