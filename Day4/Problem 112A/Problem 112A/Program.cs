using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_112A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string take1 = Console.ReadLine();
            string take2 = Console.ReadLine();
            string word1 = "";
            string word2 = "";
            if (take1.Length == take2.Length)
            {
                word1 = take1;
                word2 = take2;
            }
            word1 = word1.ToLower();
            word2 = word2.ToLower();
            int value1 = 0;
            int value2 = 0;
            for(int i = 0; i < word2.Length; i++)
            {
                if (word1[i] != word2[i])
                {
                    value1 = Convert.ToInt32(word1[i]);
                    value2 = Convert.ToInt32(word2[i]);
                    break;
                }
            }
            if (value1 == value2)
            {
                Console.WriteLine(0);
            }else if (value1 > value2)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(-1);
            }
            Console.ReadLine();
        }
    }
}
