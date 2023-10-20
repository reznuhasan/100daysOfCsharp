using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_266A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if(n>=1 && n <= 50)
                {
                    break;
                }
            }
            string sampleInput = "";
            while (true)
            {
                sampleInput = Console.ReadLine();
                int count = 0;
                foreach(char a in sampleInput)
                {
                    if(a=='R' || a=='G' || a == 'B')
                    {
                        count++;
                    }
                }
                if (count == sampleInput.Length)
                {
                    break;
                }
            }
            string diff = "";
            diff += sampleInput[0];
            for(int i = 0; i < n-1; i++)
            {
                if (sampleInput[i] != sampleInput[i + 1])
                {
                    diff += sampleInput[i + 1];
                }
            }
            Console.WriteLine("{0}",(sampleInput.Length-diff.Length));
            Console.ReadLine();
        }
    }
}
