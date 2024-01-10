using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRecap
{
    public class Program2:Program
    {
         int x;
        public Program2(int a):base(a) { 
            this.x = a;
        }
        public void DisplayChild()
        {
            Console.WriteLine("Display from child class {0}", this.x);
        }
        static void Main(string[] args)
        {
            Program2 obj = new Program2(20);
            Program obj1 = new Program2(30);
            obj.Display();
            obj1.Display();
            obj.DisplayChild();
            //Default parent it's object class.which is inheritence every explicit class defaultly
            //it's gives error cause obj1 reference from parent class
            //obj1.DisplayChild();
        }
    }
}
