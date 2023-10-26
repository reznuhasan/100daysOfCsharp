using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_427A
{
    internal class Project
    {
        static void Main(string[] args)
        {
            int n;
            while (true) {
                n = int.Parse(Console.ReadLine());
                if(n>=1 && n <= 100000)
                {
                    break;
                }
            }
            int[] arr = new int[n];
            while (true)
            {
                string sample = Console.ReadLine();
                string[] inputs = sample.Split(' ');
                int flag = 0;
                foreach(string ch in inputs)
                {
                    int value = int.Parse(ch);
                    if(value==-1 || (value>=1 && value <= 10))
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
            int police =0;
            int crime = 0;
            foreach(int num in arr)
            {
                if ((police > 0 && num==-1) || num>=1 )
                {
                    police += num;
                }
                else
                {                    
                    crime -=num;
                }
            }
            Console.WriteLine("{0}",crime);
            Console.ReadLine();
        }
    }
}

