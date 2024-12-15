using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH05_FileHandle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"D:\\Test\\Test1";
            //bool result = HandleFile.deleteAllFile(folderPath, true);
            //Console.WriteLine(result ? "Xóa thành công." : "Xóa thất bại.");
            string[] extensions = { ".txt", ".pdf", ".xlsx" };
            HandleFile.findAll(folderPath, extensions);
            Console.ReadKey();
        }
    }
}
