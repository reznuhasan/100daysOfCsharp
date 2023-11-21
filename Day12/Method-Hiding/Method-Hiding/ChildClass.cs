using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding
{
    public class ChildClass:Program
    {
        public ChildClass() : base()
        {

        }
        public override void test()
        {
            Console.WriteLine("This is child Method");
        }
        public new void test1()
        {
            Console.WriteLine("This is child Method");
        }
        public static void Main(string[] args)
        {
            ChildClass c = new ChildClass();
            c.test1();
            c.test();
            Program p = new ChildClass();
            p.test();
            p.test1();
            Console.ReadLine();
        }
    }
}
