using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int newNumber = 0;
            while (num > 0)
            {
                int val = num % 10;
                num /= 10;
                newNumber=(newNumber+val)*10;
            }
            newNumber /= 10;
            Console.WriteLine("Result: {0}",newNumber);
            Console.ReadLine();

        }
    }
}
