using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DaoNgocHuynhAnh
{
    internal class Session_02
    {
        public static void Main()
        {
            Question_3();
            Console.ReadKey();
        }
        public static void Question_1()
        {
            //Convert from degrees Celsius to Kelvin and Fahrenheit
            Console.Write("Nhap do Celsius: ");
            double C = double.Parse(Console.ReadLine());
            double F = C * 18 / 10 + 32;
            double K = C + 273;
            Console.WriteLine($"Do Kelvin = {K}");
            Console.WriteLine($"Do Fahrenheit = {F}");
        }

        public static void Question_2()
        {
            //Calculate the surface and volume of a sphere
            Console.Write("Nhap ban kinh: ");
            float r = float.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * Math.Pow(r, 2);
            double volume = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Surface = {surface}");
            Console.WriteLine($"Volume = {volume}");
        }

        public static void Question_3()
        {
            //Calculates the result of adding, subtracting, multiplying and dividing two numbers entered by the user.
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            int d = a - b;
            int e = a * b;
            int f = a / b;
            int g = a % b;
            Console.WriteLine($"a + b = {c}");
            Console.WriteLine($"a - b = {d}");
            Console.WriteLine($"a * b = {e}");
            Console.WriteLine($"a / b = {f}");
            Console.WriteLine($"a mod b = {g}");
        }
    }
}
