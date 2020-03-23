using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaEditor.entities
{

    public class Response
    {
        public String QueryExecutionId { get; set; }
        public List<List<String>> Lists { get; set; }
        public String Status { get; set; }
        public String Message { get; set; }
        public long Duration { get; set; }

        public Response() { }
        public Response(string queryExecutionId, List<List<string>> lists)
        {
            this.QueryExecutionId = queryExecutionId;
            this.Lists = lists;
        }
    }
}
