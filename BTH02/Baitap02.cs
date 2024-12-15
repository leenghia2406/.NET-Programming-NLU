using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH02
{
    internal class Baitap02
    {
        /* Viết chương trình C# để nhập một ma trận, sau đó tính tổng các phần tử nằm 
        trên đường chéo chính của ma trận và in kết quả trên màn hình. */
        public static void giaiBt02()
        {
            Console.WriteLine("Doc va in mang 2 chieu trong C#");
            Console.WriteLine("Nhap cac phan tu vao mang 2 chieu: ");
            int[,] arr = new int[3, 3];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("Phan tu : [" + i + "], [" + j + "]");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("In mang 2 chieu");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine("Tong cac phan tu tren duong cheo chinh la: " + sum);
        }

    }
}
