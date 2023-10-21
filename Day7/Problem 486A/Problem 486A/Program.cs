using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_486A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n;
            while (true)
            {
                n = long.Parse(Console.ReadLine());
                if(n>=1 && n <= 1000000000000000)
                {
                    break;
                }
            }
            long m;
            long l;
            if (n % 2 == 0)
            {
                m = n / 2;
                l = n / 2;
            }
            else
            {
                m = (n / 2) + 1;
                l = (n / 2);
            }
            long oddSum = m * m;
            long evenSum = l*(l+1);
            
            Console.WriteLine("{0}",evenSum-oddSum);
            Console.ReadLine();
        }
    }
}
