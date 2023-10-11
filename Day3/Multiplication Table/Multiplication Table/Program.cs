using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your multiplication number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}  *  {1} = {2}",i,n,i*n);
            }
            Console.ReadLine();
        }
    }
}
