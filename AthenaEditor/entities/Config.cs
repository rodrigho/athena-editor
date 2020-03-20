using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaEditor.entities
{
    class Config
    {
        public String athenaDatabase { get; set; }
        public String athenaOutputBucket { get; set; }
        public int timeSleep { get; set; }
        public String accessKeyId { get; set; }
        public String secretKey { get; set; }
        public String region { get; set; }
        public List<String> queries { get; set; }

        public bool useQueryId { get; set; }
        public String queryExecutionId { get; set; }

        public Config(String athenaDatabase, String athenaOutputBucket, int timeSleep,
                                  String accessKeyId, String secretKey, String region)
        {
            this.athenaDatabase = athenaDatabase;
            this.athenaOutputBucket = athenaOutputBucket;
            this.timeSleep = timeSleep;
            this.accessKeyId = accessKeyId;
            this.secretKey = secretKey;
            this.region = region;
            this.queries = new List<String>();
        }

    }
}
