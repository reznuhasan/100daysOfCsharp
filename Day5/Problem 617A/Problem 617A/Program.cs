using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_617A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint x;
            while (true)
            {
                x = uint.Parse(Console.ReadLine());
                if(x>=1 && x <= 1000000)
                {
                    break;
                }
            }
            int count = 0;
            while (true)
            {
                if (x == 0)
                {
                    break;
                }
                if (x >= 5)
                {
                    x -= 5;
                }else if(x >= 4)
                {
                    x -= 4;
                }else if (x >= 3)
                {
                    x -= 3;
                }
                else if (x >= 2)
                {
                    x -= 2;
                }
                else if (x >= 1)
                {
                    x -= 1;
                }
                count++;
            }
            Console.WriteLine("{0}",count);
            Console.ReadLine();
            
        }
    }
}
