using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPractice
{
    public abstract class Person
    {
        public abstract string password(string pass);
        public void Test(string className)
        {
            Console.WriteLine($"abstract class called from {className} class");
        }
    }
}
