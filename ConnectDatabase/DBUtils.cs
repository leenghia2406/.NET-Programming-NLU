using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDatabase
{
    internal class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "itnonglam";
            string user = "root";
            string password = "";
            return DBMySQLUntils.GetDBConnection(host, port, database, user, password);
        }
    }
}
