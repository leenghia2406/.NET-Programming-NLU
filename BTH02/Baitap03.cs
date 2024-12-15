using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH02
{
    internal class Baitap03
    {
        /* Viết chương trình C# để nhập một ma trận, sau đó tính tổng các hàng, các cột 
        của ma trận và in kết quả trên màn hình. */
        public static void giaiBt03()
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
            Console.WriteLine("Tong cac hang va cac cot cua ma tran la:");
            int[] rowSum = new int[3];
            int[] colSum = new int[3];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    rowSum[i] += arr[i, j];
                    colSum[j] += arr[i, j];
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine(rowSum[i]);
            }

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(colSum[j] + " ");
            }

        }

    }
}
