using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Chaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.fname);
            Console.WriteLine(person.lname);
            Console.ReadLine();
        }
    }
}
