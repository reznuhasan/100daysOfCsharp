using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1352A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if(n>=1 && n <= 10000)
                {
                    break;
                }

            }
            int flag = 0;
            int[] arr = new int[n];
            while (n > flag)
            {
                int t = int.Parse(Console.ReadLine());
                if(t>=1 && t <= 10000)
                {
                    arr[flag] = t;
                    flag++;
                }
            }
            foreach(int num in arr)
            {
                int count = 0;
                int value = num;
                while (value > 0)
                {
                    int reminder = value % 10;
                    if (reminder > 0)
                    {  
                        count++;
                    }
                    value=value/10;
                }
                Console.WriteLine("{0}", count);
                if (count == 1)
                {
                    Console.WriteLine(num);
                }
                else
                {
                    int count2= 1;
                    int value2 = num;
                    while (value2 > 0)
                    {
                        int reminder2 = value2 % 10;
                        if (reminder2 > 0)
                        {
                            Console.Write("{0} ",count2*reminder2);
                        }
                        value2 /=10;
                        count2 *= 10;
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
