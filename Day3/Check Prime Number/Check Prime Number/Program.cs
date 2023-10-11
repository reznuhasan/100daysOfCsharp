using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Number:");
            int n = int.Parse(Console.ReadLine());
            
            int flag = 0;
            for(int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    flag++;
                }
            }
            if (flag > 0)
            {
                Console.WriteLine("Not Prime Number");
            }
            else
            {
                Console.WriteLine("Prime Number");
            }
            Console.ReadLine();
        }
    }
}
