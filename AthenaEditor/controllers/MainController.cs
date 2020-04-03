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
        public HashSet<string> QueryExecutionIds { get; }
        public Dictionary<string, SchemaInfo> SchemasInfo { get; }
        public Config CurrentConfig { get; set; }
        public Connection CurrentConnection { get; set; }

        private static readonly HttpClient httpClient = new HttpClient();

        public HashSet<string> Sqlwords = new HashSet<string>{ "select","from","where","group","order","limit","by","and","inner","join","left","right",
            "having", "as", "desc", "asc", "not", "having", "like", "describe", "show", "schemas", "tables"};

        private const String Uri =  "http://127.0.0.1:8081/athena-api/";

        public List<Connection> Connections { get; set; }

        public String RelativePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        private MainController()
        {            
            QueryExecutionIds = new HashSet<string>();
            SchemasInfo = new Dictionary<string, SchemaInfo>();
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
