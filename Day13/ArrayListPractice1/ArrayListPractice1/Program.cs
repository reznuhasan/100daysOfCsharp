using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ArrayListPractice1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();
            obj.Add(30);
            obj.Add(50);
            obj.Insert(2, 70);
            obj.Insert(3, 20);
            obj.RemoveAt(2);
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
