using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Input_From_User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("My Name is "+name);
            Console.ReadLine();
        }
    }
}
