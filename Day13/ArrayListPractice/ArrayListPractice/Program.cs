using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj= new ArrayList();
            obj.Add(200);
            obj.Add(300);
            obj.Add(400);
            obj.Add(500);
            obj.Insert(1, 250);
            foreach(int i in obj)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            obj.Remove(400);
            foreach (int i in obj)
            {
                Console.Write(i+" ");
            }
            Console.ReadLine();
        }
    }
}
