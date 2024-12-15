using BTH09_WebQuanLiSinhVien.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace BTH09_WebQuanLiSinhVien.Data
{
    public class StudentRepository
    {
        private readonly string _connectionString;

        public StudentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Student> GetAllStudents()
        {
            var students = new List<Student>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM students";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student
                            {
                                Id = reader.GetInt32("id"),
                                FullName = reader.GetString("fullname"),
                                AvgScore = reader.GetDouble("avgscore")
                            });
                        }
                    }
                }
            }

            return students;
        }
    }
}
