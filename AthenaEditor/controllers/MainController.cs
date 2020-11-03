using AthenaEditor.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;

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

        public String CurrentQEId { get; set; }

        private static readonly HttpClient httpClient = new HttpClient();

        public Dictionary<string, string> TabPageQueries { get; }

        public const String Uri = "http://52.57.85.129:9012/athena-api/";

        public List<Connection> Connections { get; set; }

        public String RelativePath { get; }
        private MainController()
        {
            QueryExecutionIds = new HashSet<string>();
            SchemasInfo = new Dictionary<string, SchemaInfo>();
            TabPageQueries = new Dictionary<string, string>();
            RelativePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            CurrentQEId = "";
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
                CurrentConnection.Region, 
                true);
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
            foreach (String file in CurrentConnection.TabQueries.ToList())
            {
                try
                {
                    string query = File.ReadAllText(file);
                    TabPageQueries.Add(Path.GetFileName(file).ToLower(CultureInfo.CurrentCulture).Replace(".sql", ""), query);
                }
                catch (Exception ex)
                {
                    CurrentConnection.TabQueries.Remove(file);
                    Console.WriteLine(ex.Message);
                }
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

        public Response GetStopQuery(String queryExecutionId)
        {
            CurrentConfig.queries.Clear();
            CurrentConfig.useQueryId = true;
            CurrentConfig.queryExecutionId = queryExecutionId;
            return HttpClientService.Post(JsonConvert.SerializeObject(CurrentConfig), String.Format("{0}stop", Uri));
        }

        public async void Salute()
        {
            var responseString = await httpClient.GetStringAsync(Uri).ConfigureAwait(false);
            Console.WriteLine(responseString);
        }

    }
}
