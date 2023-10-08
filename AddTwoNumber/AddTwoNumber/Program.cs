using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number:");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("total sum result={0}", sum);
            Console.ReadLine();
        }
    }
}
