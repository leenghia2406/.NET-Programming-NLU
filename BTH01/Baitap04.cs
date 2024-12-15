using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH01
{
    internal class Baitap04
    {
        /* 
    Viết chương trình C# để nhập một mảng (mảng này không có thứ tự), sau đó chèn thêm
    phần tử mới vào trong mảng rồi in mảng trên màn hình. 
         */
        public static void giaiBaiTap4()
        {
            Console.WriteLine("Chen phan tu vao mang C#");
            Console.WriteLine("Nhap kich co mang: ");
            int arrlength = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap " + arrlength + " phan tu vao mang arr: ");
            int[] arr = new int[arrlength];
            for (int i = 0; i < arrlength; i++)
            {
                Console.Write("Phan tu - " + i + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nhap gia tri phan tu moi can chen: ");
            int newElement = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vi tri can chen vao phan tu moi nay: ");
            int newIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("In mang ban dau: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            int[] newArr = new int[arrlength + 1];
            for (int i = 0, j = 0; i < newArr.Length; i++)
            {
                if (i == newIndex)
                {
                    newArr[i] = newElement;
                }
                else
                {
                    newArr[i] = arr[j];
                    j++;
                }
            }
            Console.WriteLine("\nSau khi chen phan tu, mang co dang: ");
            foreach (int i in newArr)
            {
                Console.Write(i + " ");
            }
        }

    }
}
