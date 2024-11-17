using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DaoNgocHuynhAnh
{
    //Jagged Array
    internal class Session_07_1
    {
        private static void Main(string[] args)
        {
            
            JaggedArray(); //Không cần truyền tham số vào JaggedArray: Vì phương thức JaggedArray đã có mảng bên trong, không cần truyền vào tham số a.
        }
        //Create a jagged array and initialize it using the following values for its rows and columns; Then, display it.
         ///1 1 1 1 1
         ///2 2
         ///3 3 3 3
         ///4 4
        private static void JaggedArray()
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
    }
}
