using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_318A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n, k;
            while (true)
            {
                string sample = Console.ReadLine();
                string[] inputs = sample.Split(' ');
                n = long.Parse(inputs[0]);
                k = long.Parse(inputs[1]);
                if((n>=1 && n<= 1000000000000) && (k >= 1 && k <= 1000000000000) && (n>=k))
                {
                    break;
                }
            }
            long res = 0;
            long oddMid = n/2;
            if (n % 2 == 1)
            {
                oddMid = n / 2 + 1;
            }
            if (k<=oddMid)
            {
                res = 1 + 2 * (k - 1);
            }
            else
            {
                res = 2 + 2 * (k - 1 - oddMid);
            }
            Console.WriteLine("{0}",res);
            Console.ReadLine();

        }
    }
}
