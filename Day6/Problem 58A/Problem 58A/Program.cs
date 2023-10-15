using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_58A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            while (true)
            {
                s = Console.ReadLine();
                s = s.ToLower();
                if(s.Length>=1 && s.Length <= 100)
                {
                    break;
                }
            }
            string word = "hello";
            int j = 0;
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                int flag = 0;
                while (j<s.Length)
                {
                    if (word[i] == s[j])
                    {
                        flag++;
                        j++;
                        break;
                    }
                    j++;

                }
                if (flag == 0)
                {
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
    }
}
