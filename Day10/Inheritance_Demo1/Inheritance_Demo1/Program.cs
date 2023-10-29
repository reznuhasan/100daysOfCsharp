using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo1
{
    internal class Program
    {
        public void test1()
        {
            Console.WriteLine("test1");
        }
        public void test2()
        {
            Console.WriteLine("test2");
        }
        static void Main(string[] args)
        {
            Program2 obj = new Program2();
            Program obj1 = obj;
            obj1.test1();
        }
    }
}
