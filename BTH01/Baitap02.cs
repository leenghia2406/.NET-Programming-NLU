using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH01
{
    internal class Baitap02
    {
        /* 
    Viết chương trình C# để trộn (ghép) hai mảng có cùng kích cỡ và sau đó sắp xếp các
    phần tử của mảng trộn này theo thứ tự tăng dần.
         */
        public static void giaiBaiTap02()
        {
            Console.WriteLine("Tron hai mang trong C#");
            Console.WriteLine("Nhap so phan tu can luu giu trong mang 1: ");
            int arr1length = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap " + arr1length + " phan tu vao mang arr1");
            int[] arr1 = new int[arr1length];
            for (int i = 0; i < arr1length; i++)
            {
                Console.Write("Phan tu - " + i + ": ");
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nhap so phan tu can luu giu trong mang 2: ");
            int arr2length = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap " + arr1length + " phan tu vao mang arr2");
            int[] arr2 = new int[arr2length];
            for (int i = 0; i < arr2length; i++)
            {
                Console.Write("Phan tu - " + i + ": ");
                arr2[i] = int.Parse(Console.ReadLine());
            }
            int[] mergeArr = new int[arr1length + arr2length];
            for (int i = 0; i < arr1length; i++)
            {
                mergeArr[i] = arr1[i];
            }
            for (int i = 0; i < arr2length; i++)
            {
                mergeArr[arr1length + i] = arr2[i];
            }
            Console.WriteLine("Mang sau khi gop sap xep theo thu tu tang dan: ");
            for (int i = 0; i < mergeArr.Length - 1; i++)
            {
                for (int j = 0; j < mergeArr.Length - i - 1; j++)
                {
                    if (mergeArr[j] > mergeArr[j + 1])
                    {
                        // Hoán đổi mergeArr[j] và mergeArr[j + 1]
                        int temp = mergeArr[j];
                        mergeArr[j] = mergeArr[j + 1];
                        mergeArr[j + 1] = temp;
                    }
                }
            }

            foreach (int i in mergeArr)
            {
                Console.Write(i + " ");
            }
        }

    }
}
