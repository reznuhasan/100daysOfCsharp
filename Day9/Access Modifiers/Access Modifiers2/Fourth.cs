using Access_Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers2
{
    public class Fourth:Access_Modifiers.First
    {
        static void Main(string[] args)
        {
            Fourth obj = new Fourth();
            obj.fun2();
            obj.fun3();
            obj.fun5();
            Console.WriteLine("Project 2");
            Console.ReadLine();
        }
    }
}
