using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DaoNgocHuynhAnh
{
    internal class Session_01
    {
        public static void Main()
        {
            Question_10();
            Console.ReadKey();
        }

        public static void Question_1()
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");
        }
        public static void Question_2()
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"Gia tri a va b sau khi doi la {a} va {b}");
        }

        public static void Question_3()
        {
            Console.Write("Nhap so a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            float b = float.Parse(Console.ReadLine());
            float c = a * b;
            Console.WriteLine($"{a}*{b}={c}");
        }

        public static void Question_4()
        {
            Console.Write("Nhap so feet: ");
            double feet = double.Parse(Console.ReadLine());
            double meter = feet * 0.3048;
            Console.WriteLine($"Gia tri meter la {meter}");
        }

        public static void Question_5()
        {
            Console.Write("Nhap do Celsius: ");
            double C = double.Parse(Console.ReadLine());
            double F = C * 1.8;
            Console.WriteLine($"Gia tri do Fahrenheit la {F}");
        }
        public static void Question_6()
        {
            /*
            int s = sizeof(int);
            Console.WriteLine($"{s}");*/
            Console.WriteLine($"{sizeof(int)}");
            Console.WriteLine($"{sizeof(bool)}");
            Console.WriteLine($"{sizeof(char)}");
        }

        public static void Question_7()
        {
            Console.Write("Nhap mot chu cai: ");
            char c = char.Parse(Console.ReadLine());
            int num = c;
            Console.WriteLine($"{c} in ASCII = {num}");
        }

        public static void Question_8()
        {
            Console.Write("Nhap ban kinh: ");
            float r = float.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Dien tich vong tron la {area}");
        }

        public static void Question_9()
        {
            Console.Write("Nhap chieu dai: ");
            float a = float.Parse(Console.ReadLine());
            double area = Math.Pow(a, 2);
            Console.WriteLine($"Dien tich hinh vuong la {area}");
        }

        public static void Question_10()
        {
            Console.Write("Nhap so ngay can tinh: ");
            int days = int.Parse(Console.ReadLine());
            int year = days / 365;
            int week = (days - year * 365) / 7;
            int day = (days - year * 365) % 7;
            Console.WriteLine($"{days} days = {year} years, {week} weeks, {day} days");
        }
    }
}
