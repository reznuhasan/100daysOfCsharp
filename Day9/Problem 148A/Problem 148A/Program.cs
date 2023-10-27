using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_148A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k, l, m, n, d;
            int flag = 0;
            while (true)
            {
                k = int.Parse(Console.ReadLine());
                l = int.Parse(Console.ReadLine());
                m = int.Parse(Console.ReadLine());
                n = int.Parse(Console.ReadLine());
                d = int.Parse(Console.ReadLine());
                if(k>=1 && k <= 10)
                {
                    flag++;
                }
                if(l>=1 && l <= 10)
                {
                    flag++;
                }
                if (m >= 1 && m <= 10)
                {
                    flag++;
                }
                if (n >= 1 && n<= 10)
                {
                    flag++;
                }
                if (d >= 1 && d <= 100000)
                {
                    flag++;
                }
                if (flag==5)
                {
                    break;
                }
            }
            if(k==1 || l==1 || m==1 || n == 1)
            {
                Console.WriteLine(d);
            }
            else
            {
                int count = 0;
                for(int i = 1; i <= d; i++)
                {
                    if (i % k== 0)
                    {
                        count++;
                    }else if (i % l == 0)
                    {
                        count++;
                    }else if (i % m == 0)
                    {
                        count++;
                    }else if (i % n == 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
            Console.ReadLine();
        }
    }
}
