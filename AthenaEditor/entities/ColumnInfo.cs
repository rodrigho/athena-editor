using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaEditor.entities
{
    public class ColumnInfo
    {
        public string ColumnName { get; set; }
        public int OrdinalPosition { get; set; }
        public string IsNullable { get; set; }
        public string DataType { get; set; }
        public string Comment { get; set; }
        public string ExtraInfo { get; set; }

        public ColumnInfo(string columnName, int ordinalPosition, string isNullable, string dataType, string comment, string extraInfo)
        {
            ColumnName = columnName;
            OrdinalPosition = ordinalPosition;
            IsNullable = isNullable;
            DataType = dataType;
            Comment = comment;
            ExtraInfo = extraInfo;
        }
    }
}
