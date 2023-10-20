using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person("Rizwan", 35);
            string result = obj.showDetails();
            Console.WriteLine("{0}",result);
            Console.ReadLine();
        }
    }
}
