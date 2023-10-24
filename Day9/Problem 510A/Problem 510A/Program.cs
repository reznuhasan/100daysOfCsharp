using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_510A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            while (true)
            {
                string sample = Console.ReadLine();
                string[] inputs = sample.Split(' ');
                n = int.Parse(inputs[0]);
                m = int.Parse(inputs[1]);
                if((n>=3 && n<=50) && (m>=3 && m <= 50))
                {
                    break;
                }
            }
            for(int i = 1; i <= n; i++)
            {
                int flag = 0;
                for(int j = 1; j <= m; j++)
                {
                    if(i%4==0 && j == 1 && flag==0)
                    {
                        Console.Write("#");
                        flag = 1;
                    }else if(i%2==0 && j==m && flag == 0)
                    {
                        Console.Write("#");
                        flag = 1;
                    }else if (i % 2 == 0)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
