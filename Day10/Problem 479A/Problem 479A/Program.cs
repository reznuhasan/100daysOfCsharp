using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_479A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            while (true)
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                if((a>=1 && a<=10) && (b>=1 && b<=10) && (c>=1 && c <= 10))
                {
                    break;
                }
            }
            int res = 0;
            int con1 = a + b * c;
            int con2 = a * (b + c);
            int con3 = a * b * c;
            int con4 = (a + b) * c;
            int con5 = a + b + c;
            if (res <= con1)
            {
                res = con1;
            }
            if (res <= con2)
            {
                res = con2;
            }
            if (res <= con3)
            {
                res = con3;
            }
            if (res <= con4)
            {
                res = con4;
            }
            if (res <= con5)
            {
                res = con5;
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
