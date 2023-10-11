using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number:");
            int n = int.Parse(Console.ReadLine());
            int a = 1, b = -1;
            for(int i = 0; i < n; i++)
            {
                int sum = a + b;
                Console.Write("{0} ",sum);
                b = a;
                a = sum;
            }
            Console.ReadLine();
        }
    }
}
