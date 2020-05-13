using System;

namespace Libl
{
    class Program
    {
        static class Lib1
        {
           public static string stpow(string ha)
            {
               string x = ha + ha + ha + ha;
                return x;
            }
            public static string rev(string a)
            {
                char[] y = a.ToCharArray();
                Array.Reverse(y); // реверсировать строку и сформировать новую.
                return new string(y);
            }
            public static string  remov(string str, string s)
            {
                Console.Write("Введите подстроку: ");
                s = Console.ReadLine();
                str = str.Replace(s, "");
                return str;
            }
            public static string leng(string str)
            {
                int z = str.Length;
                string c = z.ToString();
                return c;
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
