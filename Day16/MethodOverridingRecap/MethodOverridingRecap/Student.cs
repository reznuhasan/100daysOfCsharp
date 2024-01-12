using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingRecap
{
    public class Student:Person
    {
        public override void Display() {
            Console.WriteLine("Child Method");
        }
        public new void Display1()
        {
            Console.WriteLine("Child Hiding");
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Display();
            s.Display1();
            Person p=new Student();
            p.Display();
            p.Display1();
        }
    }
}
