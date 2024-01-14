using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceRecap
{
    public class TestClass:IParent2
    {
       public void Test1()
        {
            Console.WriteLine("Called Parent 1");
        }
        public void Test2()
        {
            Console.WriteLine("Called Parent 2");
        }
    }
}
