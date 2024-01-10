using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    public class Program2:Program
    {
        public int age;
        public Program2(int age):base("Ali","Good Student")
        {
            this.age = age;
        }
       static void Main(string[] args)
        {
            Program2 obj = new Program2(20);
            Console.WriteLine("age={0},name={1},des={2}",obj.age,obj.name,obj.description);
        }
    }
}
