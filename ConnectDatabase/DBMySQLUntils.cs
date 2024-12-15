using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDatabase
{
    internal class DBMySQLUntils
    {
        public static MySqlConnection 
            GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection string
            String conString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password
                + ";Charset=utf8;";
            Console.WriteLine(conString);
            MySqlConnection conn = new MySqlConnection(conString);

            return conn;
        }
            

    }
}
