using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH06_SQLConnect
{
    internal class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "itnonglam";
            string username = "root";
            string password = "";
            // cấu trúc giống slide
            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
