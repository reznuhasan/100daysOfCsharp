using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Vowel_or_Consonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your letter:");
            char letter = Console.ReadLine()[0];
            if(letter=='a' || letter=='e' || letter=='i' || letter=='o' || letter == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
            Console.ReadLine();
        }
    }
}
