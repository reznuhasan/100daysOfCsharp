using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Way_To_Long_Words_Code_Force_71A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i = 0; i < t; i++)
            {
                string word = Console.ReadLine();
                if (word.Length<=10)
                {
                    Console.WriteLine(word);
                }
                else
                {
                    int count = 0;
                    for(int j = 1; j < word.Length-1; j++)
                    {
                        count++;
                    }
                    string newWord = word[0] + Convert.ToString(count) + word[word.Length - 1];
                    Console.WriteLine(newWord);
                }
            }
            Console.ReadLine();
        }
    }
}
