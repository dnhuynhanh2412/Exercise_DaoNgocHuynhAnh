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
            Console.Write("Ban hay nhap vao so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] items;
            items = new int[n];
            NhapPhanTu(items);
            InMang(items);
            TangMang(items);
        }

            //Nguoi dung nhap items vao array
            static void NhapPhanTu(int[] items)
            { 
            for (int i = 0; i < items.Length; i++)
                {
                    Console.Write($"Nhap vao phan tu {i + 1}: ");
                    items[i] = int.Parse(Console.ReadLine());
                }
            }
            //In array ra man hinh
            static void InMang(int[] items)
            { 
            Console.WriteLine($"Vay mang co phan tu gom: ");
            for(int i = 0; i < items.Length;i++)
                {
                    Console.WriteLine($"Phan tu {i +1}: {items[i]} ");
                }
            }

            //Increase each item by adding it with 2
            static void TangMang(int[] items)
            { 
            Console.WriteLine($"Mang sau khi cong 2: ");
            for (int i=0; i < items.Length;i++)
                {
                    items[i] += 2;
                    Console.Write($"{items[i]} ");
                }
            }

        }
    }

