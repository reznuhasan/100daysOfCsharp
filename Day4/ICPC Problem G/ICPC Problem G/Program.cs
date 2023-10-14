using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC_Problem_G
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string sampleInput = Console.ReadLine();
                int count = 0;
                for (int j = 0; j < sampleInput.Length; j++)
                {
                    if ((Convert.ToInt32(sampleInput[j]) >= 48 && Convert.ToInt32(sampleInput[j]) <= 54) || sampleInput[j] == 'W')
                    {

                        count++;

                    }
                }
                string word = "";
                if (count == sampleInput.Length)
                {
                    word += sampleInput;
                }
                int totalBall = word.Length;
                int over = 0;
                int ball = 0;
                if (totalBall >= 6)
                {
                    over = totalBall / 6;
                    ball = totalBall - (over * 6);
                }
                else if (totalBall < 6)
                {
                    ball = totalBall;
                }
                int run = 0;
                int wicket = 0;
                for (int j = 0; j < totalBall; j++)
                {
                    if (word[j] == '0')
                    {
                        run += 0;
                    }
                    else if (word[j] == '1')
                    {
                        run += 1;
                    }
                    else if (word[j] == '2')
                    {
                        run += 2;
                    }
                    else if (word[j] == '3')
                    {
                        run += 3;
                    }
                    else if (word[j] == '4')
                    {
                        run += 4;
                    }
                    else if (word[j] == '5')
                    {
                        run += 5;
                    }
                    else if (word[j] == '6')
                    {
                        run += 3;
                    }
                    else if (word[j] == 'W')
                    {
                        wicket++;
                    }
                }
                string runInWord = "Run";
                string wicketInWord = "Wicket";
                string overInWord = "Over";
                if (over > 0 && ball > 0)
                {
                    overInWord += 's';
                }
                if (run > 1)
                {
                    runInWord += 's';
                }
                if (wicket > 1)
                {
                    wicketInWord += 's';
                }
                Console.WriteLine("{0}.{1} {2} {3} {4} {5} {6}", over, ball, overInWord, run, runInWord, wicket, wicketInWord);
            }
            Console.ReadLine();
        }
    }
}
