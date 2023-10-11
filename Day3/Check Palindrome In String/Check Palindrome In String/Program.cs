using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Palindrome_In_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word:");
            string word = Console.ReadLine();
            word = word.ToLower();
            int count = 0;
            for(int i = 0, j = word.Length - 1; i < j; i++, j--)
            {
                if (word[i]!= word[j])
                {
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine("Not Palindrome");
            }
            else
            {
                Console.WriteLine("Palindrome");
            }
            Console.ReadLine();
        }
    }
}
