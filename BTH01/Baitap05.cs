using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH01
{
    internal class Baitap05
    {
        /*
    Viết chương trình C# để nhập một mảng số nguyên và sau đó chia mảng này thành hai
    mảng: một mảng chẵn và một mảng lẻ rồi in kết quả trên màn hình.
         */
        public static void giaiBaiTap05()
        {
            Console.WriteLine("Chia mang thanh mang chan, mang le trong C#");
            Console.WriteLine("Nhap kich co mang: ");
            int arrlength = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap " + arrlength + " phan tu vao mang arr: ");
            int[] arr = new int[arrlength];
            for (int i = 0; i < arrlength; i++)
            {
                Console.Write("Phan tu - " + i + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int evenLength = 0;
            int oddLength = 0;

            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    evenLength++;
                }
                else
                {
                    oddLength++;
                }
            }
            int[] evenArr = new int[evenLength];
            int[] oddArr = new int[oddLength];

            int evenIndex = 0;
            int oddIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] % 2) == 0)
                {
                    evenArr[evenIndex] = arr[i];
                    evenIndex++;
                }
                else
                {
                    oddArr[oddIndex] = arr[i];
                    oddIndex++;
                }
            }
            Console.WriteLine("Cac phan tu chan la: ");
            foreach (int i in evenArr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nCac phan tu le la: ");
            foreach (int i in oddArr)
            {
                Console.Write(i + " ");
            }
        }

    }
}
