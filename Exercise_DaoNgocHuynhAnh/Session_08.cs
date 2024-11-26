using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DaoNgocHuynhAnh
{
    //Strings
    internal class Session_08
    {
        static string s;
        //to find the length of a string without using a library function.
        static void FindLength()
        {
            int len = 0;
            foreach (char c in s) 
                len++;
            Console.WriteLine($"Do dai cua chuoi la {len}"); 
        }

        // to separate individual characters from a string.
        static void SeperateChar()
        {
            foreach(char c in s)
                Console.WriteLine(c);
        }

        // to print individual characters of the string in reverse order
        static void StringReverse()
        {
            Console.WriteLine("Individual characters of the string in reverse order: ");
            for(int i = s.Length - 1; i >= 0; i--)
                Console.WriteLine(s[i]);
        }

        // to count the total number of words in a string
        static int CountWords(string s)
        {
            int count = 0;

            //bỏ khoảng trắng thừa có trong chuỗi
            s = s.Trim(); //bỏ khoảng trắng đầu và cuối chuỗi
            while (s.IndexOf("  ") != -1)
                s = s.Replace("  ", " ");

            //đếm
            foreach (char c in s)
                if (c == ' ') count++;
                return count+1;
        }

        //to compare two strings without using a string library functions.
        //trả về 0 nếu s1 == s2, 1 nếu s1>s2, -1 nếu s1<s2
        static int Compare2Strings(string s1, string s2)
        {
            int min_len = s1.Length < s2.Length ? s1.Length : s2.Length;
            for(int i = 0; i < min_len; i++)
            {
                if (s1[i] > s2[i]) return 1;
                if (s1[i] < s2[i]) return -1;
            }
            return s1.Length > s2.Length ? 1 : s1.Length < s2.Length? -1 : 0;
        }
        static void Main()
        {
            // to input a string and print it.
            Console.Write("Nhap mot chuoi: ");
            s = Console.ReadLine();
            Console.WriteLine($"Chuoi ban nhap la: ");
            FindLength();
            SeperateChar();
            StringReverse();
            int wordCount = CountWords(s);
            Console.WriteLine($"So tu trong chuoi là: {wordCount}");
            string s1 = "Huynh Anh";
            string s2 = "Anh Anh";
            Compare2Strings(s1, s2);
            Console.WriteLine(s1.CompareTo(s2));
        }
    }
}
