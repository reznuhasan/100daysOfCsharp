using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    internal class Class2:Program
    {
        public override void greeting()
        {
            Console.WriteLine("Rizwan is a good boy");
        }
        static void Main()
        {
            Class2 obj = new Class2();
            obj.greeting();
            Console.ReadLine();
        }
    }
}
