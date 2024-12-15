using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH01
{
    internal class Baitap01
    {
        /* 
    Viết chương trình C# để khai báo một mảng, sau đó lưu giữ các phần tử vào mảng rồi in
    các phần tử mảng này trên màn hình.
         */
        public static void giaiBaiTap01()
        {
            Console.WriteLine("Doc va in vao cac phan mang trong C#");
            Console.WriteLine("Nhap vao 10 phan tu mang");
            int[] numArr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Phan tu - " + i + ": ");
                numArr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("In cac phan tu mang: ");
            foreach (int num in numArr)
            {
                Console.Write(num + " ");
            }
        }

    }
}
