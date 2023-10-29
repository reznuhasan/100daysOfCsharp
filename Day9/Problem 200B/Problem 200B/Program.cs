using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_200B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if(n>=1 && n <= 100)
                {
                    break;
                }
            }
            int[] arr = new int[n];

            while (true) {
                string sample = Console.ReadLine();
                string[] inputs =sample.Split(' ');
                int flag = 0;
                foreach (string ch in inputs)
                {
                    int value = int.Parse(ch);
                    if(value>=0 && value <= 100)
                    {
                        arr[flag] = value;
                        flag++;
                    }
                }
                if (flag == n)
                {
                    break;
                }
            }
            int sum = 0;
            foreach(int num in arr)
            {
                sum += num;
            }
            double result = (double)sum / (double)n;
            string formatValue = result.ToString("F12");
            Console.WriteLine("{0}",formatValue);
            Console.ReadLine();
        }
    }
}
