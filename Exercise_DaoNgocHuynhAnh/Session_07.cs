using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DaoNgocHuynhAnh
{
    internal class Session_07
    {
        private static void Main(string[] args)
        {
            //Matrix NxM (N,M was prompted from user) randomly
            int[,] a;
            Console.Write("Nhap so dong: "); int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: "); int cols = int.Parse(Console.ReadLine());
            a = new int[rows, cols];
            NhapMangNgauNhien(a, rows, cols);
            InMang(a, rows, cols);
            //Console.Write("Nhap so can tim: ");
            //int val = int.Parse(Console.ReadLine());
            //InGiaTri(a, val);
            InGiaTriLonNhat(a);
            TimGiaTriNhoNhat(a);
        }

        static void NhapMangNgauNhien(int[,] a, int rows, int cols)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rnd.Next(0, 100) + 1; //So ngau nhien tu 1 den 100
                }
            }
        }

        static void InMang(int[,] a, int rows, int cols)
        {
            Console.WriteLine("Ma tran la: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void InGiaTri(int[,] a, int value)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == value)
                    {
                        Console.WriteLine($"{value} xuat hien tai dong {i} cot {j} \n");
                    }

                }
            }
        }

        static void InGiaTriLonNhat(int[,] a)
        {
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
            }
            Console.WriteLine($"Gia tri lon nhat la: {max}");
        }

        static void TimGiaTriNhoNhat(int[,] a)
        {
            int min = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                    }
                }
                Console.WriteLine($"Gia tri nho nhat cua dong {i} la: {min}");
            }
        }
    }
}
