using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    internal class Program
    {
        public void test(int a)
        {
            Console.WriteLine("test method 1");
        }
        public void test(string name)
        {
            Console.WriteLine("test method 2");
        }
        public void test(int a,string name)
        {
            Console.WriteLine("test method 3");
        }
        public void test(string name,int a)
        {
            Console.WriteLine("test method 4");
        }
        public void show()
        {
            Console.WriteLine("show method 1");
        }
        static void Main(string[] args)
        {
        }
    }
}
