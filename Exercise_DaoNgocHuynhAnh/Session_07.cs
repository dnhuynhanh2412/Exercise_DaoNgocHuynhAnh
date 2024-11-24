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
            Console.Write("Nhap so dong cho ma tran thuong: "); int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot cho ma tran thuong: "); int cols = int.Parse(Console.ReadLine());
            a = new int[rows, cols];
            NhapMangNgauNhien(a, rows, cols);
            InMang(a, rows, cols);
            //Console.Write("Nhap so can tim: ");
            //int val = int.Parse(Console.ReadLine());
            //InGiaTri(a, val);
            //InGiaTriLonNhat(a);
            //TimGiaTriNhoNhatDong(a);
            //TimGiaTriNhoNhatCot(a);
            int[,] transpose;
            transpose = new int[cols, rows];
            //ChuyenViMang(a,transpose);
            int[,] matrixsquare;
            Console.Write("Nhap so dong va cot cho ma tran vuong: "); int Rows = int.Parse(Console.ReadLine());
            int Cols = Rows;
            matrixsquare = new int[Rows, Cols];
            InDuongCheo(matrixsquare, Rows, Cols);
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
            Console.WriteLine();
        }

        static void TimGiaTriNhoNhatDong(int[,] a) //Find the min value of ith row/col of the matrix.
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int minrow = a[i, 0];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < minrow)
                    {
                        minrow = a[i, j];
                    }
                }
                Console.WriteLine($"Gia tri nho nhat cua dong {i} la: {minrow}");
            }
            Console.WriteLine();
        }

        static void TimGiaTriNhoNhatCot(int[,] a) //Find the min value of ith row/col of the matrix.
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                int mincol = a[0, j];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    if (a[i, j] < mincol)
                    {
                        mincol = a[i, j];
                    }
                }
                Console.WriteLine($"Gia tri nho nhat cua cot {j} la: {mincol}");
            }
            Console.WriteLine();
        }

        static void ChuyenViMang(int[,] a, int[,] transpose) //Chuyển đổi dòng thành cột (Chuyển vị)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    transpose[j, i] = a[i, j];
                }
            }
            
            Console.WriteLine("Ma tran sau khi chuyen vi la: ");
            for (int i = 0; i < transpose.GetLength(0); i++)
            {
                for (int j = 0; j < transpose.GetLength(1); j++)
                {
                    Console.Write(transpose[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void InDuongCheo(int[,] matrixsquare, int Rows, int Cols)  //Print the main/secondary diagonal values of the matrix.
        {
            Random rnd = new Random();
            for (int i = 0; i < matrixsquare.GetLength(0); i++)
            {
                for (int j = 0; j < matrixsquare.GetLength(1); j++)
                {
                    matrixsquare[i, j] = rnd.Next(0, 100) + 1; //So ngau nhien tu 1 den 100
                    Console.Write(matrixsquare[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Duong cheo chinh cua ma tran vuong la: ");
            for (int i = 0; i < matrixsquare.GetLength(0); i++)
            {
                Console.Write(matrixsquare[i, i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("Duong cheo phu cua ma tran vuong la: ");
            for (int i = 0; i < matrixsquare.GetLength(0); i++)
            {
                Console.Write(matrixsquare[matrixsquare.GetLength(0) - i - 1, i] + "\t");
            }
        }
    }
}
