using CopyConstructorRecap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyContructorRecap
{
    class StaticConstructor
    {
        static int x=10;
        static StaticConstructor() {
            Console.WriteLine("Hello Microsoft",x);
        }
        public void Display()
        {
            Console.WriteLine("Value of x is {0}", x);
        }
        public static void Main() {
          StaticConstructor obj=new StaticConstructor();
            obj.Display();

        }
    }
}
