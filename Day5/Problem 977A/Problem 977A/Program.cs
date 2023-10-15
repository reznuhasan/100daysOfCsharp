using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_977A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint number, time;
            while (true)
            {
                string sampleInput = Console.ReadLine();
                string[] inputs = sampleInput.Split(' ');
                number = uint.Parse(inputs[0]);
                time = uint.Parse(inputs[1]);
                if((number>=2 && number<= 1000000000) && (time>=1 && time <= 50))
                {
                    break;
                }
            }
            for(uint i = time; i > 0; i--)
            {
                if (number % 10 == 0)
                {
                    number /= 10;
                }
                else
                {
                    number--;
                }
            }
            Console.WriteLine("{0}",number);
            Console.ReadLine();

        }
    }
}
