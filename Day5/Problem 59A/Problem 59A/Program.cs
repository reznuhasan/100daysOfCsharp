using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_59A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            while (true)
            {
                word = Console.ReadLine();
                if(word.Length>=1 && word.Length <= 100)
                {
                    break;
                }
            }
            int lower = 0;
            int upper = 0;
            for(int i = 0; i < word.Length; i++)
            {
                int num = Convert.ToInt32(word[i]);
                if(num>=97 && num <= 122)
                {
                    lower++;
                }else if(num>=65 && num <= 90)
                {
                    upper++;
                }
            }
            if (upper >lower)
            {
                Console.WriteLine("{0}",word.ToUpper());
            }
            else
            {
                Console.WriteLine("{0}", word.ToLower());
            }
            Console.ReadLine();
        }
    }
}
