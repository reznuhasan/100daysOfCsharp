using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_and_Time_Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
           //general situation 
            Console.WriteLine("{0}",dt);
            Console.WriteLine("{0:d}",dt);
            Console.WriteLine("{0:D}", dt);
            Console.WriteLine("{0:f}", dt);
            Console.WriteLine("{0:F}", dt);
            Console.WriteLine("{0:g}", dt);
            Console.ReadLine();
        }
    }
}
