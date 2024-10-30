using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DaoNgocHuynhAnh
{
    internal class Session_05
    {
        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Main55(string[] args)
        {
            int a = 6, b = 7;
            Console.WriteLine($"Before call a={a}, b={b}");
            swap(ref a, ref b);
            Console.WriteLine($"After call a={a}, b={b}");
            Console.ReadKey();
        }


        //Game tài xỉu
        //Máy tính sẽ đổ 3 con xúc sắc ngẫu nhiên
        //Người chơi sẽ đoán là tài hay xỉu
        static int rollDice()
        {
            Random rnd = new Random();
            int die_1= rnd.Next(6) + 1;
            int die_2 = rnd.Next(6) + 1;
            int die_3 = rnd.Next(6) + 1;
            int sum_of_dice = die_1 + die_2 + die_3;
            return sum_of_dice;
        }
        static void play1Round()
        {
            int com_dice = rollDice();
            Console.Write("Ban doan Tai hay Xiu <T/X>");
            string user_guessing = Console.ReadLine();
            if (user_guessing.ToUpper().Equals("T"))
            {
                if(com_dice>=10) //Tài
                    Console.WriteLine("Ban thang");
                else
                    Console.WriteLine("Ban thua");
            }
            else if (user_guessing.ToUpper().Equals("X"))
            {
                if (com_dice < 10) //Xỉu
                    Console.WriteLine("Ban thang");
                else
                    Console.WriteLine("Ban thua");
            }
            else
            {
                Console.WriteLine("Vui long chon cho dung");
            }
        }
        static void game_engine()
        {
            do 
            {
                play1Round();

                Console.WriteLine("Ban choi nua khong? <C/K>");
                string choice = Console.ReadLine();
                if (choice.ToUpper().Equals("K"))
                    break;

            } while (true);
            Console.WriteLine("Mai choi nua nhe");
        }
        public static void Main()
        {
            game_engine();
        }
    }
}
