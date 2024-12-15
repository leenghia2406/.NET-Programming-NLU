using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH02
{
    internal class Baitap04
    {
        /* Viết chương trình C# để nhập hai ma trận, sau đó so sánh xem hai ma trận này 
        có bằng nhau không và in kết quả trên màn hình. */
        public static void giaiBt04()
        {
            Console.WriteLine("Nhap so hang cua ma tran thu nhat: ");
            int row1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot cua ma tran thu nhat: ");
            int col1 = int.Parse(Console.ReadLine());
            int[,] matrix1 = new int[row1, col1];
            Console.WriteLine("Nhap cac phan tu cua ma tran thu nhat: ");
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    Console.Write($"Phan tu - [{i}],[{j}]: ");
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Nhap so hang cua ma tran thu hai: ");
            int row2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot cua ma tran thu hai: ");
            int col2 = int.Parse(Console.ReadLine());
            int[,] matrix2 = new int[row2, col2];
            Console.WriteLine("Nhap cac phan tu cua ma tran thu hai: ");
            for (int i = 0; i < row2; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    Console.Write($"Phan tu - [{i}],[{j}]: ");
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("In ma tran thu nhat:");
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("In ma tran thu hai:");
            for (int i = 0; i < row2; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine();
            }

            if (row1 != row2 || col1 != col2)
            {
                Console.WriteLine("Hai ma tran khong bang nhau vi khac kich thuoc.");
            }
            else
            {
                bool isEqual = true;
                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < col1; j++)
                    {
                        if (matrix1[i, j] != matrix2[i, j])
                        {
                            isEqual = false;
                            break;
                        }
                    }
                    if (!isEqual)
                    {
                        break;
                    }
                }

                if (isEqual)
                {
                    Console.WriteLine("Hai ma tran bang nhau.");
                }
                else
                {
                    Console.WriteLine("Hai ma tran khong bang nhau.");
                }
            }
        }

    }
}
