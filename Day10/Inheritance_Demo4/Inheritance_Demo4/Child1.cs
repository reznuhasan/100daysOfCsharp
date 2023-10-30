using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo4
{
    internal class Child1:Program
    {
        public Child1(int i) : base(i)
        {
            Console.WriteLine("This is child constructor");
        }
        static void Main()
        {
            Console.Write("Enter your number: ");
            int num = int.Parse(Console.ReadLine());
            Child1 obj = new Child1(num);
            Console.ReadLine();
        }
    }
}
