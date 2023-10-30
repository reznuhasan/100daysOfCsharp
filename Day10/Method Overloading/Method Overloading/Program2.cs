using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    internal class Program2:Program
    {
        public void show(int a)
        {
            Console.WriteLine("this show method 2");
        }
        public void test(int a)
        {
            Console.WriteLine("this test 5");
        }
        static void Main()
        {
            Program2 obj = new Program2();
            obj.show(12);
            obj.test("rizwan",12);
            obj.test(12);
            Console.ReadLine();
        }
    }
}
