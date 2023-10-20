using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_122A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if(n>=1 && n <= 1000)
                {
                    break;
                }
            }
            
            if(n%4==0 || n%7==0 || n%47==0 || n%74==0 || n%447==0 || n%474==0 || n%477==0  || n%744==0 || n % 774 == 0 || 747==0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
    }
}
