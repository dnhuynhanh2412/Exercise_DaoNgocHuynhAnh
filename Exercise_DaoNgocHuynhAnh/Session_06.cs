using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DaoNgocHuynhAnh
{
    internal class Session_06
    {
        public static void Main()
        {
        Question_01();
        Console.ReadKey();
        }

        public static void Question_01()
        {
            Console.Write("Ban hay nhap vao so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] items;
            items = new int[n];

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("Nhap vao mot so: ");
            }
            Console.WriteLine($"Vay mang co {n} phan tu gom: ");
        }
    }
}
