using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListPractice
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();
            Console.Write("Enter your numbers of input number:");
            int n=int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int value=Convert.ToInt32(Console.ReadLine());
                obj.Add(value);
            }
            foreach(int i in obj)
            {
                Console.Write(i+" ");
            }
            Console.ReadLine();
        }
        
    }
}
