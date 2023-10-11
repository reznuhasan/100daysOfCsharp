using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Factorial Number:");
            int n = int.Parse(Console.ReadLine());
            int fac=1;
            for(int i = 1; i <=n; i++)
            {
                fac *= i;
            }

            Console.WriteLine(fac);
            Console.ReadLine();

        }
    }
}
