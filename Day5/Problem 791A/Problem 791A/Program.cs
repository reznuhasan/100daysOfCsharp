using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_791A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint limak;
            uint bob;
            while (true)
            {
                string numbers=Console.ReadLine();
                string[] numbersArr = numbers.Split(' ');
                limak = uint.Parse(numbersArr[0]);
                bob = uint.Parse(numbersArr[1]);
                if((limak>=1 && limak<=10) && (bob>=1 && bob <= 10))
                {
                    break;
                }
            }
            uint count=0;
            while (true)
            {
                limak *= 3;
                bob *= 2;
                count++;
                if (limak > bob)
                {
                    break;
                }
            }
            Console.WriteLine("{0}",count);
            Console.ReadLine();
        }
    }
}
