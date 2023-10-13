using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_339A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while (true)
            {
                input=Console.ReadLine();
                int count = 0;
                foreach(char a in input)
                {
                    if((Convert.ToInt32(a)>=49 && Convert.ToInt32(a)<=51) || a == '+')
                    {
                        count++;
                    }
                }
                if (count == input.Length && input.Length<=100)
                {
                    break;
                }
            }
            char[] charArray = input.ToCharArray();
            
            for (int i = 0; i < charArray.Length - 2; i += 2)
              {

                for(int j = i + 2; j < charArray.Length; j += 2)
                {

                    if (Convert.ToInt32(charArray[i])>Convert.ToInt32(charArray[j]))
                    {
                      char temp = charArray[i];
                      charArray[i] = charArray[j];
                      charArray[j] = temp;

                  }
                }

            }
            string result = "";
            for(int i = 0; i < charArray.Length; i++)
            {
                result += charArray[i];
            }
            Console.WriteLine("{0}",result);
            Console.ReadLine();
        }
    }
}
