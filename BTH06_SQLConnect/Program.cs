using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH06_SQLConnect
{
    internal class Program
    {
        static void Main111(string[] args)
        {
            Console.WriteLine("Getting Connection....");
            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                Console.WriteLine("Openning Connection");
                conn.Open();
                Console.WriteLine("Connection Successful");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
