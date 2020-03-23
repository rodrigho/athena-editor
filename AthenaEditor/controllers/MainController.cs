using AthenaEditor.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AthenaEditor.controllers
{
    public class MainController
    {
        public MainForm MainForm { get; set; }
        public ConnectionManager ConnectionManager { get; set; }

        private static MainController mainController;
        public HashSet<string> QueryExecutionIds { get; set; }
        public Config CurrentConfig { get; set; }
        public Connection CurrentConnection { get; set; }

        private static readonly HttpClient httpClient = new HttpClient();

        public string[] Sqlwords = { "select ", " select "," from "," where "," group "," order "," limit "," by "," and ",
            " having ", " desc ", " asc ", " not ", " having ", " like ", " describe "};

        public List<Connection> Connections { get; set; }

        public String RelativePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        private MainController()
        {            
            QueryExecutionIds = new HashSet<string>();
        }

        public static MainController GetInstance()
        {
            if (mainController == null)
                mainController = new MainController();
            return mainController;
        }

        public void StartMainForm()
        {
            ConnectionManager.Hide();
            MainForm = new MainForm();
            MainForm.Closed += (s, args) => ConnectionManager.Close();
            CurrentConfig = new Config(
                CurrentConnection.AthenaDatabase,
                CurrentConnection.AthenaOutputBucket,
                1000,
                CurrentConnection.AccessKeyId,
                CurrentConnection.SecretKey,
                CurrentConnection.Region);
            MainForm.Show();
            MainForm.FillSchemas();
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

        public Response GetQueryResult(String query, bool useQueryId, String queryExecutionId)
        {
            CurrentConfig.queries.Clear();
            CurrentConfig.queries.Add(query);
            CurrentConfig.useQueryId = useQueryId;
            CurrentConfig.queryExecutionId = queryExecutionId;
            return HttpClientService.Post(JsonConvert.SerializeObject(CurrentConfig), "http://127.0.0.1:8081/athena-api/execute");
        }

        public async void Salute()
        {
            Uri uri = new Uri("http://127.0.0.1:8081/athena-api/");
            var responseString = await httpClient.GetStringAsync(uri).ConfigureAwait(false);
            Console.WriteLine(responseString);
        }

    }
}
