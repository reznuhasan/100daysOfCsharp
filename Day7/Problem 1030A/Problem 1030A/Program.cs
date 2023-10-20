using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1030A
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
            string[] inputs;
            while (true)
            {
                string sampleInput = Console.ReadLine();
                inputs = sampleInput.Split(' ');
                int flag= 0;
                foreach(string num in inputs)
                {
                    if(num=="1" || num == "0")
                    {
                        flag++;
                    }
                }
                if (flag == inputs.Length && flag==n)
                {
                    break;
                }
            }
            int hard = 0;
            foreach(string ch in inputs)
            {
                if (ch == "1")
                {
                    hard = 1;
                    break;
                }
            }
            if (hard == 1)
            {
                Console.WriteLine("HARD");
            }
            else
            {
                Console.WriteLine("EASY");
            }
            Console.ReadLine();
        }
    }
}
