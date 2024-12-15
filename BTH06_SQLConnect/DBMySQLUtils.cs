using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH06_SQLConnect
{
    internal class DBMySQLUtils
    {
        public static MySqlConnection
        GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String
            string conString = "Server=" + host + ";Port=" + port + ";Database=" + database + ";User Id=" + username + ";Password=" + password + ";";
            Console.WriteLine(conString);
            MySqlConnection conn = new MySqlConnection(conString);
            return conn;
        }
    }
}
