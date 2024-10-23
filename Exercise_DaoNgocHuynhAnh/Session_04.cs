using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DaoNgocHuynhAnh
{
    internal class Session_04
    {
        public static void Main()
        {
            Question_3();
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
    }
}
