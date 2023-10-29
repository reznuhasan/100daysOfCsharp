using Inheritance_Demo2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Single_Inheritance:Program
    {
        public void test2()
        {
            Console.WriteLine("from second class");
        }
        static void Main()
        {
            Single_Inheritance obj = new Single_Inheritance();
            obj.test1();
            obj.test2();
            Console.ReadLine();
        }
    }
}
