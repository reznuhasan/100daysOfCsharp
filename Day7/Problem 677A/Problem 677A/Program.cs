using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_677A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, h;
            while (true)
            {
                string sample = Console.ReadLine();
                string[] inputs = sample.Split(' ');
                n = int.Parse(inputs[0]);
                h = int.Parse(inputs[1]);
                if((n>=1 && n<=1000) && (h>=1 && h <= 1000))
                {
                    break;
                }
            }
            int[] arr = new int[n];
            int flag = 0;
            while (flag < n)
            {
                string sample = Console.ReadLine();
                string[] inputs = sample.Split(' ');
                foreach(string ch in inputs)
                {
                    if(int.Parse(ch)>=1 && int.Parse(ch) <= 2 * h)
                    {
                        arr[flag] = int.Parse(ch);
                        flag++;
                    }
                }
            }
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= h)
                {
                    sum++;
                }
                else
                {
                    sum += 2;
                }
            }
            Console.WriteLine("{0}",sum);
            Console.ReadLine();
        }
    }
}
