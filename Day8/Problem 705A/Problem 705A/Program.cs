using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_705A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if(n>=1 && n <= 100)
                {
                    break;
                }
            }
            string str = "";
            for(int i = 1; i <n; i++)
            {
                if (i % 2 == 1)
                {
                    str += "I hate that ";
                }
                else
                {
                    str += "I love that ";
                }
            }
            if (n % 2 == 1)
            {
                str += "I hate it";
            }
            else
            {
                str += "I love it";
            }
            Console.WriteLine("{0}",str);
            Console.ReadLine();
        }
    }
}
