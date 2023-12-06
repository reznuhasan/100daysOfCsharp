using System;
using System.Collections.Generic;
namespace GenericList
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(70);
            list.Add(60);
            list.Add(50);
            list.Add(40);
            list.Add(80);
            list.Add(90);
            list.Insert(2,100);
            list.RemoveAt(3);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
