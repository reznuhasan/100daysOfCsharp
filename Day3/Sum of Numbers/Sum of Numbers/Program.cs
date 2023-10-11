using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your array size:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
                sum += arr[i];
            }
            Console.WriteLine("Result={0}",sum);
            Console.ReadLine();
        }
    }
}
