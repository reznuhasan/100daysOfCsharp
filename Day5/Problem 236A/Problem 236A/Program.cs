
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_236A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            while (true)
            {
                word = Console.ReadLine();
                int count = 0;
                foreach (char a in word)
                {
                    if (Convert.ToInt32(a) >= 97 && Convert.ToInt32(a) <= 122)
                    {
                        count++;
                    }
                }
                if (word.Length == count && word.Length <= 100)
                {
                    break;
                }
            }
            string distinctWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                int flag = 0;
                for (int j = 0; j < distinctWord.Length; j++)
                {
                    if (word[i] == distinctWord[j])
                    {
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    distinctWord += word[i];
                }
            }
            if (distinctWord.Length % 2 == 1)
            {
                Console.WriteLine("IGNORE HIM!");
            }
            else
            {
                Console.WriteLine("CHAT WITH HER!");
            }
            Console.ReadLine();
        }
    }
}
