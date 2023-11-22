using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    public abstract class Program
    {
        public int length,width,height,radius;
        public const double pi= 3.1416;
        public abstract void Area();
        public void test()
        {
            Console.WriteLine("Program run successfully");
        }
    }
}
