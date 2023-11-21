using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding
{
    public class Program
    {
        public string name;
        public int age;
      
        public Program() { }
        public Program(string name,int age) { 
            this.name = name;
            this.age = age;
        }
        public void showDetails()
        {
            Console.WriteLine("Name:{0},Age {1}",this.name,this.age);
        }
        //overriding method
        public virtual void test()
        {
            Console.WriteLine("This is Parent Method");
        }
        //method hiding or shadowing
        public void test1()
        {
            Console.WriteLine("This is parent method2");
        }
    }
}
