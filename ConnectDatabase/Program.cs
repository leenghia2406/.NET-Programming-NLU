using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDatabase
{
    internal class Program
    {
        static void Main111(string[] args)
        {
            Console.WriteLine("Getting connection ...");
            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                Console.WriteLine("Oppening Connection ...");
                conn.Open();
                Console.WriteLine("Connection successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " +ex.Message);
            }
            Console.Read();
        }
    }
}
