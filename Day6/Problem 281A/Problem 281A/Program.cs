using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_281A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sampleInput;
            while (true)
            {
                sampleInput = Console.ReadLine();
                int flag = 0;
                foreach(char a in sampleInput)
                {
                    if((Convert.ToInt32(a)>=65 && Convert.ToInt32(a)<=90) || (Convert.ToInt32(a) >= 97 && Convert.ToInt32(a) <= 122))
                    {
                        flag++;
                    }
                }
                if(flag==sampleInput.Length && sampleInput.Length <= 1000)
                {
                    break;
                }
            }
            string result = "";
            for(int i = 0; i < sampleInput.Length; i++)
            {
                if (i == 0 && (Convert.ToInt32(sampleInput[i]) >= 97 && Convert.ToInt32(sampleInput[i]) <= 122))
                {
                    result += sampleInput[i].ToString().ToUpper();
                }
                else
                {
                    result += sampleInput[i];
                }
            }
            Console.WriteLine("{0}", result);
            Console.ReadLine();
        }
    }
}
