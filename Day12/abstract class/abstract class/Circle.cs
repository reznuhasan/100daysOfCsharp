using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    internal class Circle:Program
    {
        public override void Area()
        {
            Console.WriteLine("Area is {0}",pi*(radius*radius));
        }
        public static void Main(string[] args)
        {
            Circle c = new Circle();
            c.radius = 3;
            c.Area();
            c.test();
            Console.ReadLine();

        }
    }
    
}
