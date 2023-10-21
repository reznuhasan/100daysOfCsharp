using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_160A
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
            int flag = 0;
            while (flag < n)
            {
                string sample = Console.ReadLine();
                string[] inputs = sample.Split(' ');
                foreach(string ch in inputs)
                {
                    if(int.Parse(ch)>=1 && int.Parse(ch) <= 100)
                    {
                        arr[flag] = int.Parse(ch);
                        flag++;
                    }
                }
            }
            int sum = 0;
            foreach(int a in arr)
            {
                sum += a;
            }
            for(int i = 0; i < n-1; i++)
            {
                for(int j = i+1; j < n; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            int person = 0;
            int personCoin = 0;
            foreach(int a in arr)
            {
                if (person <= sum-person)
                {
                    person += a;
                    personCoin++;
                }
            }
            Console.WriteLine("{0}",personCoin);
            Console.ReadLine();
        }
    }
}
