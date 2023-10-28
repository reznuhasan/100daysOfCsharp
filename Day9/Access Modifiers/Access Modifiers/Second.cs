using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    public class Second:First
    {
        static void Main()
        {
            Second obj = new Second();
            obj.fun6();
            obj.fun5();
            obj.fun4();
            obj.fun2();
            obj.fun3();
            Console.ReadLine();
        }
    }
}
