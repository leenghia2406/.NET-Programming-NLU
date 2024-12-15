using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDatabase
{
    internal class TruyVanDL
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Lay ra doi tuong connection de ket noi vao database
            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                Console.WriteLine("Oppening Connection ...");
                conn.Open();
                Console.WriteLine("Connection successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.Read();
        }
    }
}
