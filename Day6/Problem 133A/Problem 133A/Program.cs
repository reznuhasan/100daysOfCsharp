using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_133A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string p;
            while (true)
            {
                p = Console.ReadLine();
                if(p.Length>=1 && p.Length <= 100)
                {
                    break;
                }
            }
            int count = 0;
            for(int i = 0; i < p.Length; i++)
            {
                if (p[i] == 'H')
                {
                    count++;
                    break;
                }else if (p[i] == 'Q')
                {
                    count++;
                    break;
                }else if (p[i] == '9')
                {
                    count++;
                    break;
                }
            }
            if (count > 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
    }
}
