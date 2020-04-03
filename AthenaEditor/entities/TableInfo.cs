using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaEditor.entities
{
    public class TableInfo
    {
        public string TableName { get; set; }
        public Dictionary<string, ColumnInfo> Columns { get; }

        public TableInfo(string tableName, Dictionary<string, ColumnInfo> columns)
        {
            TableName = tableName;
            Columns = columns;
        }
    }
}
