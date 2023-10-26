using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_750A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            while (true)
            {
                string sample = Console.ReadLine();
                string[] inputs = sample.Split(' ');
                n = int.Parse(inputs[0]);
                k = int.Parse(inputs[1]);
                if((n>=1 && n<=10)&&k>=1 && k <= 240)
                {
                    break;
                }
            }
            int count = 0;
            for(int i = 1; i <= n; i++)
            {
                k += (i * 5);
                if (k <= 240)
                {
                    count++;
                }
            }
            Console.WriteLine("{0}",count);
            Console.ReadLine();
        }
    }
}
