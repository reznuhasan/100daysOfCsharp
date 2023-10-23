using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("1234");
            person1.FirstName="";
            Console.WriteLine(person1.FirstName);
            Console.ReadLine();
        }
    }
}
