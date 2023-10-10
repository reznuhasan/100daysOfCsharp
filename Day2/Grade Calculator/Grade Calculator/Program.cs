using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Marks:");
            uint mark = uint.Parse(Console.ReadLine());
            if (mark>=90 && mark <= 100)
            {
                Console.WriteLine("Your Grade is A");
            }
            else if(mark>=80 && mark <= 89)
            {
                Console.WriteLine("Your Grade is B");
            }
            else if(mark>=70 && mark <= 79)
            {
                Console.WriteLine("Your Grade is C");
            }
            else if(mark>=60 && mark <= 69)
            {
                Console.WriteLine("Your Grade is D");
            }
            else
            {
                Console.WriteLine("Your are fail");
            }
            Console.ReadLine();
        }
    }
}
