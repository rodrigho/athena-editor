using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaEditor.entities
{
    public class Connection
    {
        public String Name { get; set; }
        public String AthenaDatabase { get; set; }
        public String AthenaOutputBucket { get; set; }
        public String AccessKeyId { get; set; }
        public String SecretKey { get; set; }
        public String Region { get; set; }
        public String Comment { get; set; }

        public Connection(string name, string athenaDatabase, string athenaOutputBucket, string accessKeyId, string secretKey, string region, string comment)
        {
            Name = name;
            AthenaDatabase = athenaDatabase;
            AthenaOutputBucket = athenaOutputBucket;
            AccessKeyId = accessKeyId;
            SecretKey = secretKey;
            Region = region;
            Comment = comment;
        }
    }
}
