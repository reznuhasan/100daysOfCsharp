using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    internal class Third
    {
        static void Main()
        {
            First obj = new First();
            obj.fun2();
            obj.fun4();
            obj.fun5();
            Console.ReadLine();
        }
    }
}
