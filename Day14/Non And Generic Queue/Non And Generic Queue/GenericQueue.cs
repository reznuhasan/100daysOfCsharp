using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_And_Generic_Queue
{
    public class GenericQueue
    {
      static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            numbers.Enqueue(4);
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("___________");
            numbers.Dequeue();
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(numbers.Peek());
            Console.ReadLine();
        }
    }
}
