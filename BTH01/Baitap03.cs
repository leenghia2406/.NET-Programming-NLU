using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH01
{
    internal class Baitap03
    {
        /* 
    Viết chương trình C# để đếm số lần xuất hiện của từng phần tử trong mảng và in kết quả
    trên màn hình
         */
        public static void giaiBaiTap03()
        {
            Console.WriteLine("Dem so lan xuat hien cua tung phan tu trong mang C#");
            Console.WriteLine("Nhap so phan tu can luu giu trong mang: ");
            int arrlength = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap " + arrlength + " phan tu vao mang arr: ");
            int[] arr = new int[arrlength];
            for (int i = 0; i < arrlength; i++)
            {
                Console.Write("Phan tu - " + i + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Dictionary<int, int> frequencyDict = new Dictionary<int, int>();
            foreach (int num in arr)
            {
                if (frequencyDict.ContainsKey(num))
                {
                    frequencyDict[num]++;
                }
                else
                {
                    frequencyDict[num] = 1;
                }
            }
            Console.WriteLine("Tan suat xuat hien cua cac phan tu trong mang la: ");
            foreach (KeyValuePair<int, int> entry in frequencyDict)
            {
                Console.WriteLine("Phan tu " + entry.Key + " xuat hien " + entry.Value + " lan");
            }

        }

    }
}
