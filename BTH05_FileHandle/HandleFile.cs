using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace BTH05_FileHandle
{
    internal class HandleFile
    {
        public static bool deleteAllFile(String path, bool option)
        {
            if(!Directory.Exists(path))
            {
                Console.WriteLine("Thu muc khong ton tai");
                return false;
            }
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                File.Delete(file);
                Console.WriteLine("Da xoa file: " + file);
            }
            string[] subDirectories = Directory.GetDirectories(path);
            foreach (string subdir in subDirectories)
            {
                if (option)
                {
                    deleteAllFile(subdir, true);
                    Directory.Delete(subdir);
                    Console.WriteLine("Da xoa thu muc: " + subdir);
                }
                else
                {
                    deleteAllFile(subdir, false);
                }
            }
            return true;
        }

        public static void findAll(string path, string[] extensions)
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine("Thư mục không tồn tại.");
                return;
            }

            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                string fileExtension = Path.GetExtension(file);
                if (extensions.Contains(fileExtension, StringComparer.OrdinalIgnoreCase))
                {
                    Console.WriteLine("File phù hợp: " + file);
                }
            }
            string[] subDirectories = Directory.GetDirectories(path);
            foreach (string subdir in subDirectories)
            {
                findAll(subdir, extensions);
            }
        }
        public static ArrayList import(string path)
        {
            ArrayList students = new ArrayList();

            // Kiểm tra file có tồn tại không
            if (!File.Exists(path))
            {
                Console.WriteLine("File không tồn tại.");
                return students;
            }

            // Sử dụng EPPlus để đọc dữ liệu
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // Set license context for EPPlus
            using (var package = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Lấy sheet đầu tiên
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++) // Bỏ qua hàng đầu (header)
                {
                    Student student = new Student
                    {
                        Id = int.Parse(worksheet.Cells[row, 1].Text),
                        Fullname = worksheet.Cells[row, 2].Text,
                        Age = int.Parse(worksheet.Cells[row, 3].Text),
                        AvgGrade = double.Parse(worksheet.Cells[row, 4].Text)
                    };

                    students.Add(student);
                }
            }

            return students;
        }

    }
}
