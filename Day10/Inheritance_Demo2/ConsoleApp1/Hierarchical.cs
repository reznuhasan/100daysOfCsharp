using Inheritance_Demo2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Hierarchical:Program
    {
        public void test4()
        {
            Console.WriteLine("here program hierarchical parent cause it's also used in single inheritance");
        }
        static void Main()
        {
            Hierarchical obj = new Hierarchical();
        }
    }
}
