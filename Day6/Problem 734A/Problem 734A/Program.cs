using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_734A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if(n>=1 && n <= 1000000)
                {
                    break;
                }
            }
            string s;
            while (true)
            {
                s = Console.ReadLine();
                int flag = 0;
                foreach(char ch in s)
                {
                    if(ch=='A' || ch == 'D')
                    {
                        flag++;
                    }
                }
                if(flag==s.Length && s.Length == n)
                {
                    break;
                }
            }
            int anton = 0;
            int danik = 0;
            foreach(char ch in s)
            {
                if (ch == 'A')
                {
                    anton++;
                }
                else
                {
                    danik++;
                }

            }
            if (anton > danik)
            {
                Console.WriteLine("Anton");
            }else if (danik > anton)
            {
                Console.WriteLine("Danik");
            }
            else
            {
                Console.WriteLine("Friendship");
            }
            Console.ReadLine();
        }
    }
}
