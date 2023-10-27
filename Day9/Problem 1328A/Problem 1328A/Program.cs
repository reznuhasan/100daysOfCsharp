using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1328A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t;
            while (true)
            {
                t = int.Parse(Console.ReadLine());
                if(t>=1 && t <= 10000)
                {
                    break;
                }
            }
            int flag = 0;
            while (true)
            {
                string sample = Console.ReadLine();
                string[] inputs = sample.Split(' ');
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                if((a>=1 && a<=1000000000) || (b>=1 && b <= 1000000000))
                {
                    int reminder = a % b;
                    if (reminder != 0)
                    {
                        Console.WriteLine("{0}", b - reminder);
                    }
                    else
                    {
                        Console.WriteLine("{0}",reminder);
                    }
                    flag++;
                }
                if (flag == t)
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
