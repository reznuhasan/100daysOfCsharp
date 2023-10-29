using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Multi_level:Single_Inheritance
    {
        public void test3()
        {
            Console.WriteLine("from multi level class");
        }
        static void Main()
        {
            Multi_level obj = new Multi_level();
            obj.test1();
            obj.test2();
            Console.ReadLine();
        }
    }
}
