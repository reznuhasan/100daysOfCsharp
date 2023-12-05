using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_Practice
{
    public struct Program:Program1
    {
        //1)value type
        //2)allocated in stack
        //3)initialize in struct not possible
        //4)inheritance not possible
        //5)new keyword not need
        //6)int,bool,float etc which are store in stack they are struct type
        //7)parameter less constructor not possible
        //8)inherite class or abstract class is not possible but interface possible. 
        public string Name {  get; set; }
        public void Running()
        {
            Console.WriteLine($"{Name} are running too fast");
        }
        public void Test()
        {
            Console.WriteLine("Test is complete");
        }
        static void Main(string[] args)
        {
            Program obj=new Program();
            obj.Name = "Rizwan";
            obj.Running();
            Console.ReadLine();
        }
    }
}
