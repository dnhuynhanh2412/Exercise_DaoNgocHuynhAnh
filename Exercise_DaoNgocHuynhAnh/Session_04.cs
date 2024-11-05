using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercise_DaoNgocHuynhAnh
{
    internal class Session_04
    {
        public static void Main()
        {
            //Question_3();
            Ex_5_2();
            Console.ReadKey();
        }
        public static void Question_1()
        //Kiểm tra số chẵn hay số lẻ
        {
            Console.Write("Nhap 1 so: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            { Console.WriteLine($"{a} la so chan"); }
            else { Console.WriteLine($"{a} la so le"); }
        }

        public static void Question_2()
        //Tìm số lớn nhất trong 3 số
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so c: ");
            int c = int.Parse(Console.ReadLine());
            int Max = a;
            if (b > Max) ;
            { Max = b; }
            if (c > Max) { Max = c; }
            Console.WriteLine($"So lon nhat la {Max}");

        }

        public static void Question_3()
        //Xác định điểm tọa độ nằm trong góc phần tư thứ mấy
        {
            Console.Write("Nhap toa do mot diem:\nx = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            if (x == 0 && y == 0)
            { Console.WriteLine("Diem nam ngay goc toa do"); }
            else if (x > 0 && y > 0)
            { Console.WriteLine("Toa do diem thuoc phan tu thu nhat"); }
            else if (x < 0 && y > 0)
            { Console.WriteLine("Toa do diem thuoc phan tu thu hai"); }
            else if (x < 0 && y < 0)
            { Console.WriteLine("Toa do diem thuoc phan tu thu ba"); }
            else if (x > 0 && y < 0)
            { Console.WriteLine("Toa do diem thuoc phan tu thu tu"); }

        }

        public static void Ex_1()
        //Kiem tra Tam giac deu, tam giac can hay tam giac thuong
        {
            Console.Write("Nhap do dai canh thu nhat: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap do dai canh thu hai: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap do dai canh thu ba: ");
            double c = double.Parse(Console.ReadLine());
            if (a <= 0 || b <= 0 || c <= 0 || (a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                Console.WriteLine("Day khong phai la mot tam giac");
            }
            else if (a == b && b == c)
            {
                Console.WriteLine("Day la mot tam giac deu");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Day la mot tam giac can");
            }
            else
            {
                Console.WriteLine("Day la mot tam giac thuong");
            }
        }

        public static void Ex_2()
        //Viet chuong trinh Đọc 10 số và tính trung bình và tổng của chúng
        {
            int sum = 0;
            int count = 10;
            Console.WriteLine("10 so la:");

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            double avg = (double)sum / count;
            Console.WriteLine($"Tong 10 so la: {sum}");
            Console.WriteLine($"Trung binh 10 so la: {avg}");
        }

        public static void Ex_3()
        //Viết bảng cửu chương của một số cho trước
        {
            Console.Write("Nhap 1 so nguyen de thuc hien bang cuu chuong:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                /*for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i*j}");
                }*/
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
        public static void Ex_4()
        //Write a program to display a pattern like triangles with a number
        {
            Console.Write("Nhap so dong cua tam giac: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap con so ban muon: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)                     ///Điều khiển số dòng của tam giác
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }

        public static void Ex_5()
        //Pattern 01: Số 1 sẽ được nhắc lại ở mỗi dòng
        {
            Console.Write("Nhap so hang cua tam giac ma ban muon tao: ");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Ex_5_1()
        //Pattern 02: Ko có số bị lặp lại ( 1 > 1 2 > 1 2 3 ... )
        {
            int count = 1; 
            Console.Write("Nhap so hang cua tam giac ma ban muon tao: ");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count + " ");
                    count++;
                }
                Console.WriteLine();
            }
        }
        
        public static void Ex_5_2()
        //Pattern 03: tựa pattern 2 nhưng including space 
        {
            int count = 1;
            Console.Write("Nhap so hang cua tam giac ma ban muon tao: ");
            int rows = int.Parse(Console.ReadLine());
            ///Điều khiển số dòng của tam giác
            for(int i = 1; i <= rows; i++)
            {
                ///In khoảng trắng để canh giữa tam giác
                for(int space = rows; space > i; space--)
                {
                    Console.Write(" ");
                }
                ///In các số trong dòng hiện tại
                for (int j = 1; j <= i; j++) 
                {
                    Console.Write(count + " ");
                    count++;
                }
                Console.WriteLine();                
            }
        }
        
        public static void Ex_6()
        //Write a program to display the n terms of harmonic series and their sum.
        //(1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n term)
        {
            Console.Write("Nhap so hang n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;
            Console.WriteLine("Chuoi day so la: ");
            for(int i = 1; i <= n; i++)
            {
                double term = 1.0 / i;
                Console.Write($"{term} ");
                sum += term;
            }
            
            Console.WriteLine($"\nTong cua chuoi ham so n so hang la: {sum}");
        }

        public static void Ex_7()
        // Write a program to find the ‘perfect’ numbers within a given number range.
        {
            Console.Write("Nhap gia tri gioi han duoi: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia tri gioi han tren");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine($"Gia tri cua so hoan hao nam giua {start} va {end}");

        static bool IsPerfectNumber(int number)
            {
                if (number < 2) return false;
                for (int i = 2; i <= number / 2; i++)
                    if (number % i == 0)
                        return false;
                return true;
            }
        }
    }
}
