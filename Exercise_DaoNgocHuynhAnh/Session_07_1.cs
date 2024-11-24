using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise_DaoNgocHuynhAnh
{
    //Exercises Multidimensional Arrays slides page 32
    internal class Session_07_1
    {
        private static void Main(string[] args)
        {
            //Exercise_01(); //Không cần truyền tham số vào JaggedArray: Vì phương thức JaggedArray đã có mảng bên trong, không cần truyền vào tham số a.
            Exercise_02();
        }
        //Create a jagged array and initialize it using the following values for its rows and columns; Then, display it.
        ///1 1 1 1 1
        ///2 2
        ///3 3 3 3
        ///4 4
        private static void Exercise_01()
        {
            int[][] JaggedArray = {
                new int[] {1,1,1 },
                new int[] {2,2 },
                new int[] {3,3,3,3 },
                new int[] {4,4 }
            };

            Console.WriteLine("Mang lom chom: ");
            for (int i = 0; i < JaggedArray.Length; i++) // Duyệt qua từng hàng
            {
                //.Write($"Hàng {i}: ");
                for (int j = 0; j < JaggedArray[i].Length; j++) // Duyệt qua từng phần tử trong hàng
                {
                    Console.Write(JaggedArray[i][j] + " ");
                }
                Console.WriteLine(); // Xuống dòng sau mỗi hàng
            }
        }

        //Create a Jagged Array with random integer numbers (or by user input) by getting the 
        //number of rows and columns from the user and printing the data in the array to the user.
        private static void Exercise_02()
        {
            int[][] a;
            Console.Write("Nhap so hang: "); int row = int.Parse(Console.ReadLine());
            a = new int[row][];
            NhapMangNgauNhien(a);
            Console.WriteLine("Mang da tao la: ");
            InMang(a);
            InGTLNmoiDong(a);
            Console.WriteLine();
            InGTLNcuaMang(a);
        //Sap xep dong cua mang theo thu tu nho den lon
            Console.WriteLine("Mang da sap xep tang dan: ");
            SortRowAtoZ(a);
            InMang(a);
            InSoNguyenTo(a);
        // Search and print all positions of a number (enter from the user).
            Console.WriteLine("Nhap so ban can tim: ");
            int value = int.Parse(Console.ReadLine());
            TimGiaTri(a,value);
        }

        // Print the biggest number of each row and the largest number of the whole array.
        private static void NhapMangNgauNhien(int[][] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Nhap so cot cho dong a[{i + 1}]: ");
                int col = int.Parse(Console.ReadLine());
                a[i] = new int[col];
                for (int j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = rnd.Next(0, 100) + 1;
                }
            }
            Console.WriteLine();
        }
        private static void InMang(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
        private static void InGTLNmoiDong(int[][] a)
        {
            for (int i = 0;i < a.Length; i++)
            {
                int maxrow = a[i][0];
                for (int j = 1; j < a[i].Length; j++)
                {
                    if (a[i][j] > maxrow)
                    {
                        maxrow = a[i][j];
                    }
                }
                Console.WriteLine($"GTLN cua dong {i+1} la {maxrow}");
            }
        }

        private static void InGTLNcuaMang(int[][] a)
        {
            int maxarray = a[0][0];
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0;j < a[i].Length; j++)
                {
                    if(a[i][j] > maxarray)
                    {
                        maxarray = a[i][j];
                    }
                }
            }
            Console.WriteLine($"GTLN cua mang la {maxarray}");
        }

        private static void SortRowAtoZ(int[][] a)
        {
            foreach (int[] row in a)
            {
                for (int i = 0; i < row.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (row[i] < row[j])
                        {
                            int s = row[i];
                            row[i] = row[j];
                            row[j] = s;
                        }
                    }
                }
            }
        }

        private static bool IsPrime(int n)
        {
            if (n <= 1) return false; // 0 và 1 không phải số nguyên tố
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                    if (n % i == 0) 
                    return false;
            }
            return true;
        }
        static void InSoNguyenTo(int[][] a)
        {
            Console.WriteLine("Mang co cac so nguyen to la:");
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (IsPrime(a[i][j]))
                    {
                        Console.Write(a[i][j] + "\t");
                    }
                }
            }
            Console.WriteLine();
        }

        static void TimGiaTri(int[][] a, int value)
        {
            for(int i =0; i < a.Length;i++)
            {
                for(int j =0; j< a[i].Length; j++)
                {
                    if (a[i][j] == value)
                        Console.WriteLine($"{value} nam o dong {i} cot {j}");
                }
            }
        }

    }
}
