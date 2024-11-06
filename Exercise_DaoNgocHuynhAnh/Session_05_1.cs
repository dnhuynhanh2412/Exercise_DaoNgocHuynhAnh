using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DaoNgocHuynhAnh
{
    internal class Session_05_1
    {
        //30-10-2024
        static int Question_01(int a, int b, int c)
        //Tìm số lớn nhất trong 3 số
        //Improve the next version that accept at least 1 parameter
        {
            //return Math.Max(Math.Max(a,b),c);

            /*int max = a;
            if(b>max)
                max = b;
            else
                max = c;*/

            int max = 0;
            if (a > b && a > c)
                max = a;
            else if (b > c && b > a)
                max = b;
            else
                max = c;
            return max;            
       
        
            /*Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so c: ");
            int c = int.Parse(Console.ReadLine());
            int Max = a;
            if (b > Max) ;
            { Max = b; }
            if (c > Max) { Max = c; }
            Console.WriteLine($"So lon nhat la {Max}");*/
        }

        //Câu 4
        //Kiểm tra xem có phải là số nguyên tố hay không
        static bool isPrime(int number)
        {
            if(number < 2) return false;
            for (int i = 2; i <= number / 2; i++)
                if (number % i == 0)
                    return false;
            return true;
        }

        //In số nguyên tố nhỏ hơn N
        static void printPrimeNumberUnderN(int n)
        {
            for (int i = 2;i < n;i++)
                if(isPrime(i))
                    Console.WriteLine(i);
        }

        //In N số nguyên tố đầu tiên
        static void printFirstNprime(int n)
        {
            int so = 2;
            int dem = 0;
            while (dem<n)
            {
                if(isPrime(so))
                {
                    Console.Write(so + ", ");
                    dem++;
                }
                so++;
            }
        }

        static void Main(string[] args)
        {
            printPrimeNumberUnderN(10);              //In số nguyên tố nhỏ hơn 100
            //printFirstNprime(10);                      //In 100 số nguyên tố đầu tiên
            Console.ReadKey();
        }
    }
}
