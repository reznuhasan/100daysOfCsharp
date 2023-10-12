using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_282A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < t; i++)
            {
                string word="";
                string operators = Console.ReadLine();
                if(operators=="++X" || operators=="X++" || operators=="--X" || operators == "X--")
                {
                    word += operators;
                }
                if(word=="++X" || word == "X++")
                {
                    count++;
                }else if(word=="--X" || word == "X--")
                {
                    count--;
                }
            }
            Console.WriteLine("{0}",count);
            Console.ReadLine();
        }
    }
}
