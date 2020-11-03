using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaEditor.util
{
    class TextConstants
    {
        public static string SUCCEEDED = "SUCCEEDED";

        //Errors
        public static string Error = "Error";

        public static string ErrorDeleteConnections = "You need to choose a connection";

        public static string FailedConnection = "Failed to connect to Athena\n\nCheck your region and AWS credentials";

        //Information
        public static string Information = "Information";

        public static string SuccessConnection = "Successfully made the Athena connection";

        //Queries
        public static string QueryInfoSchema = "SELECT table_schema, table_name, column_name, ordinal_position, is_nullable, data_type, comment, extra_info FROM information_schema.columns;";
        
    }
}
