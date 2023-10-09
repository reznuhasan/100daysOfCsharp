using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "45";
            int b = Convert.ToInt32(a);
            Console.WriteLine(b);
            int c = int.Parse(a);
            Console.WriteLine(c);
            Console.ReadLine();

        }
    }
}
