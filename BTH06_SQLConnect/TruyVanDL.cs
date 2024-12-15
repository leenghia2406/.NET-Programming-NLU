using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH06_SQLConnect
{
    internal class TruyVanDL
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Lấy đối tượng Connection ra kết nối vào DB
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                TruyVanSinhVien(conn);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ ex);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                // Đóng kết nối
                conn.Close();
                // Tiêu hủy đối tượng, giải phóng tài nguyên
                conn.Dispose();
            }
            Console.Read();
        }

        private static void TruyVanSinhVien(MySqlConnection conn)
        {
            string sql = "Select * from sinhvien";
            // Tạo một đối tượng command
            MySqlCommand cmd = new MySqlCommand();
            // Liên hợp Command với Connection
            cmd.Connection = conn;
            cmd.CommandText = sql;

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Chỉ số index của cột Emp_ID trong câu lệnh SQL
                        int maSV = reader.GetInt32(0);
                        string hoten = reader.GetString(1);
                        DateTime ngaysinh = reader.GetDateTime(2);
                        int tuoi = reader.GetInt32(3);
                        double diemTB = reader.GetDouble(4);
                        Console.WriteLine("------------------");
                        Console.WriteLine("MSSV: " + maSV);
                        Console.WriteLine("Hoten: " + hoten);
                        Console.WriteLine("Ngaysinh: " + ngaysinh);
                        Console.WriteLine("Tuoi: " + tuoi);
                        Console.WriteLine("DiemTB: "+ diemTB);
                    }
                }
            }
        }
    }
}
