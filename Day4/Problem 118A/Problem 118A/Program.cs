using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_118A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sampleInput = Console.ReadLine();
            int count = 0;
            for(int i = 0; i < sampleInput.Length; i++)
            {
                if ((Convert.ToInt32(sampleInput[i])>=65 && Convert.ToInt32(sampleInput[i])<=90) || (Convert.ToInt32(sampleInput[i]) >= 97 && Convert.ToInt32(sampleInput[i]) <= 122))
                {
                    count++;
                }
            }
            string word = "";
            if (sampleInput.Length == count)
            {
                word = sampleInput.ToLower();
            }
            string sampleResult = "";
            for(int i = 0; i < word.Length; i++)
            {
                if (word[i] != 'a' && word[i] != 'e' && word[i] != 'o' && word[i] != 'i' && word[i] !='y' && word[i] != 'u')
                {
                    sampleResult += ("." + word[i]);
                }
            }
            Console.WriteLine("{0}",sampleResult);
            Console.ReadLine();
        }
    }
}
