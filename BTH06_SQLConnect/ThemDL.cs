using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH06_SQLConnect
{
    internal class ThemDL
    {
        public static int Value { get; private set; }
        static void Main111(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Lấy đối tượng Connection ra kết nối vào DB
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                // Câu lệnh insert
                string sql = "insert into sinhvien (mssv, hoten, ngaysinh, tuoi, diemtb)" +
                    "values (@mssv, 'Nguyen Quang Hai', '19/19/1999', 22, 9.1)";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;

                // Tạo đối tượng parameter
                MySqlParameter mssv = new MySqlParameter("@mssv", SqlDbType.NVarChar);
                mssv.Value = "22130180";
                cmd.Parameters.Add(mssv);
                // Thực thi command (dùng cho delete, insert, update)
                int rowCount = cmd.ExecuteNonQuery();
                Console.WriteLine("Row affected: " +rowCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                // Đóng kết nối
                conn.Close();
                // Tiêu hủy đối tượng, giải phóng tài nguyên
                conn.Dispose();
                conn = null;
            }
            Console.Read();
        }
    }
}
