using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_467A
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
            int room = 0;
            int availableRoom = 0;
            while (true)
            {
                string sample = Console.ReadLine();
                string[] inputs = sample.Split(' ');
                int p = int.Parse(inputs[0]);
                int q = int.Parse(inputs[1]);
                if((p>=0 && p<=100) && (q>=0 && q<=100) && p <= q)
                {
                    if (q-p>=2)
                    {
                        availableRoom++;
                    }
                    room++;
                }
                if (room == n)
                {
                    break;
                }
            }
            Console.WriteLine("{0}",availableRoom);
            Console.ReadLine();

        }
    }
}
