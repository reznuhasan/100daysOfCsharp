using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_41A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s, t;
            while (true)
            {
                s = Console.ReadLine();
                t = Console.ReadLine();
                int flag1 = 0;
                int flag2 = 0;
                foreach(char ch in s)
                {
                    if(ch>='a' && ch <= 'z')
                    {
                        flag1++;
                    }
                }
                foreach(char ch in t)
                {
                    if(ch>='a' && ch <= 'z')
                    {
                        flag2++;
                    }
                }
                if(flag1==s.Length && flag2==t.Length && (flag1>=1 && flag1<=100) && (flag2>=1 && flag2 <= 100))
                {
                    break;
                }
            }
            int flag = 0;
            if (s.Length != t.Length)
            {
                flag = 1;
            }
            else
            {
                for (int i = 0, j = t.Length - 1; i < s.Length; i++, j--)
                {
                    if (s[i] != t[j])
                    {
                        flag = 1;
                        break;
                    }
                }

            }
            if (flag == 1)
            {
                Console.WriteLine("NO");
            }else if (flag == 0)
            {
                Console.WriteLine("YES");
            }
            Console.ReadLine();
        }
    }
}
