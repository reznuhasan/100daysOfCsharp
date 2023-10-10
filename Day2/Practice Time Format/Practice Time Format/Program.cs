using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Time_Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt= DateTime.Now;
            //normal date format
            Console.WriteLine("{0}",dt);
            Console.WriteLine("{0:d}",dt);
            Console.WriteLine("{0:D}", dt);
            Console.WriteLine("{0:f}",dt);
            Console.WriteLine("{0:F}",dt);
            Console.WriteLine("{0:G}",dt);
            Console.WriteLine("{0:g}",dt);
            Console.WriteLine("{0:m}",dt);
            Console.WriteLine("{0:M}",dt);
            Console.WriteLine("{0:t}",dt);
            Console.WriteLine("{0:T}",dt);
            Console.WriteLine("{0:y}",dt);
            Console.ReadLine();
        }
    }
}
