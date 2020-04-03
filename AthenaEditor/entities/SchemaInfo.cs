using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaEditor.entities
{
    public class SchemaInfo
    {
        public string TableSchema { get; set; }
        public Dictionary<string, TableInfo> Tables { get; set; }

        public SchemaInfo(string tableSchema, Dictionary<string, TableInfo> tables)
        {
            TableSchema = tableSchema;
            Tables = tables;
        }
    }
}
