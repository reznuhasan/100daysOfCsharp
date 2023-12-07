using System;
using System.Collections.Generic;

namespace SortedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(30);
            list.Add(50);
            list.Add(20);
            list.Add(40);
            list.Insert(5, 90);
            list.Sort();
            foreach (int i in list)
            {
                Console.WriteLine(i);   
            }
            Console.ReadLine();
        }
    }
}