using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_158A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            while (true)
            {
                string sampleInput = Console.ReadLine();
                string[] inputs = sampleInput.Split(' ');
                n = int.Parse(inputs[0]);
                k = int.Parse(inputs[1]);
                if ((n>=1 && n<=50) && (k>=1 && k <= 50) && (n>=k))
                {
                    break;
                }
            }
            int[] arr = new int[n];
            while (true)
            {
                string sampleValue = Console.ReadLine();
                string[] values = sampleValue.Split(' ');
                for(int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(values[i]);
                }
                if (values.Length == n)
                {
                    break;
                }
            }
            int count = 0;
            int searchValue = arr[k-1];
            for(int i = 0; i < n; i++)
            {
                if (searchValue <= arr[i] && arr[i] > 0)
                {
                    count++;
                }
            }
            Console.WriteLine("{0}",count);
            Console.ReadLine();
        }
    }
}
