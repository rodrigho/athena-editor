using AthenaEditor.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        public HashSet<string> QueryExecutionIds { get; }
        public Dictionary<string, SchemaInfo> SchemasInfo { get; }
        public Config CurrentConfig { get; set; }
        public Connection CurrentConnection { get; set; }

        private static readonly HttpClient httpClient = new HttpClient();

        public Dictionary<string, string> TabPageQueries { get; }

        public const String Uri =  "http://127.0.0.1:8081/athena-api/";

        public List<Connection> Connections { get; set; }

        public String RelativePath { get; }
        private MainController()
        {
            QueryExecutionIds = new HashSet<string>();
            SchemasInfo = new Dictionary<string, SchemaInfo>();
            TabPageQueries = new Dictionary<string, string>();
            RelativePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
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
            LoadSQLFiles();
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

        public void SaveConnectionsIntoFile()
        {
            string json = JsonConvert.SerializeObject(Connections);
            string jsonFile = Path.Combine(RelativePath, "connections.json");            
            File.WriteAllText(jsonFile, json);
        }

        public void LoadSQLFiles()
        {
            foreach(String file in CurrentConnection.TabQueries)
            {
                string query = File.ReadAllText(file);
                TabPageQueries.Add(Path.GetFileName(file).ToLower(CultureInfo.CurrentCulture).Replace(".sql", ""), query);
            }
        }

        public Response GetQueryResult(String query, bool useQueryId, String queryExecutionId)
        {
            CurrentConfig.queries.Clear();
            CurrentConfig.queries.Add(query);
            CurrentConfig.useQueryId = useQueryId;
            CurrentConfig.queryExecutionId = queryExecutionId;
            return HttpClientService.Post(JsonConvert.SerializeObject(CurrentConfig), String.Format("{0}execute", Uri));
        }

        public async void Salute()
        {
            var responseString = await httpClient.GetStringAsync(Uri).ConfigureAwait(false);
            Console.WriteLine(responseString);
        }

    }
}
