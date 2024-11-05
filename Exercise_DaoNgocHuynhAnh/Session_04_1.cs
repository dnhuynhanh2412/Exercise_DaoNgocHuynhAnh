using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DaoNgocHuynhAnh
{
    internal class Session_04_1
    //Game doan so
    //Máy tính sẽ nghĩ ngẫu nhiên 1 số từ 1 đến 10
    //Người dùng sẽ đoán xem số đó là số nào
    //Nếu đoán sai sẽ thông báo...
    {
    static void ex01()
    {
            do
            {
                //1.Máy nghĩ ngẫu nhiên 1 số
                Random rnd = new Random();
                int comp_num = rnd.Next(0, 10) + 1;
                /*Console.WriteLine("Ban nghi so may <1..10>");
                int user_num = int.Parse(Console.ReadLine());
                if (comp_num == user_num)
                    Console.WriteLine("Ban la thien tai");
                else
                    Console.WriteLine($"May tinh nghi so {comp_num}. \n" + 
                        $"Ban thi nghi so {user_num}. \n" + $"Chuc ban may man lan sau");*/

                //2.Hỏi người dùng đoán cho đúng thì thôi
                int count = 0;
                bool isContinue = true;
                do
                {
                    count++;
                    Console.WriteLine("Ban doan so may <1..10> ");
                    int user_num = int.Parse(Console.ReadLine());
                    //3.Kiểm tra kết quả
                    if (comp_num == user_num)
                    {
                        Console.WriteLine($"Ban doan trung sau {count} lan");
                        isContinue = false;
                    }
                    else
                    {
                        if (comp_num > user_num)
                            Console.WriteLine("So ban doan nho hon so may nghi");
                        else
                            Console.WriteLine("So ban doan lon hon so may nghi");
                    }
                } while (isContinue);

                Console.WriteLine("==============================");
                Console.Write("Choi nua khong? <C/K: >");
                string tl = Console.ReadLine();
                if (tl.ToUpper().Equals("K"))
                {
                    Console.WriteLine("Thang ma cho go. Lan sau khong choi nua!");
                    return;
                }
            } while (true);
    }
        

    }
}
