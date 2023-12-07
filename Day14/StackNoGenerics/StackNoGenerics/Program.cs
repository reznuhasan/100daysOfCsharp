using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackNoGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack numbers = new Stack();
            numbers.Push(10);
            numbers.Push(20);
            numbers.Push(30);
            numbers.Push(40);
            
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Pop();
            Console.WriteLine("__________________________");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers.Peek());
            Console.WriteLine(numbers.Contains(40));
            Console.WriteLine(numbers.Contains(30));
            Console.ReadLine();
        }
    }
}
