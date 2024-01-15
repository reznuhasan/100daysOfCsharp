
using EnumRecap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNameSpace
{
    public class TestClass
    {
        public TestClass() {
            Console.WriteLine("Test Class Created");
        }
        public void TakeDays(Days d)
        {
            Console.WriteLine("Take Days Called {0}", d);
        }
    }
}
