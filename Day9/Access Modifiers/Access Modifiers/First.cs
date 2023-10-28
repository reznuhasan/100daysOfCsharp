using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    public class First
    {
        private void fun1()
        {
            Console.WriteLine("This is private word");
        }
        public void fun2()
        {
            Console.WriteLine("This is public word");
        }
        protected void fun3()
        {
            Console.WriteLine("This is protected word");
        }
        internal void fun4()
        {
            Console.WriteLine("This is internal word");
        }
        protected internal void fun5()
        {
            Console.WriteLine("This is protected internal word");
        }
        private protected void fun6()
        {
            Console.WriteLine("This is private protected word");
        }
        static void Main()
        {
            First obj = new First();
            obj.fun1();
            obj.fun2();
            obj.fun3();
            obj.fun4();
            obj.fun5();
            obj.fun6();
            Console.ReadLine();
        }
    }
}
