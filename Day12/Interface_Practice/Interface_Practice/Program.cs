using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practice
{
    public class Program:Interface1,Interface2
    {
       public string name;
        public int age;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        public void test1()
        {
            Console.WriteLine("Hello world");
        }
        public void test2(string name,int age) {
            Console.WriteLine("Name:{0},Age:{1}",name,age);
        }
        static void Main(string[] args)
        {
            Program obj=new Program();
            obj.test1();
            obj.name = "rizwan";
            obj.age = 15;
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.age);

            Console.ReadLine();
        }
    }
}
