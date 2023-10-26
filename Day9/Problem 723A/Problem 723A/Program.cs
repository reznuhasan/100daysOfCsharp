using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_723A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            while (true)
            {
                string sample = Console.ReadLine();
                string[] inputs = sample.Split(' ');
                arr[0] = int.Parse(inputs[0]);
                arr[1] = int.Parse(inputs[1]);
                arr[2] = int.Parse(inputs[2]);
                int count = 0;
                foreach(int num in arr)
                {
                    if(num >= 1 && num<= 1000)
                    {
                        count++;
                    }
                }
                if(count==arr.Length)
                {
                    break;
                }
            }
            int mid=0;
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            Console.WriteLine("{0}", (arr[0] - arr[1]) + (arr[1] - arr[2]));
            Console.ReadLine();
        }
    }
}
