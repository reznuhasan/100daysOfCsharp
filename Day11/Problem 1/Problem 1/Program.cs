using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint numerator=0, denominator=0, numberOfDecimalPlace;
            while (true)
            {
                string inputString=Console.ReadLine();
                string[] inputs = inputString.Split(' ');

                if (inputs.Length == 3)
                {
                    
                    if (int.Parse(inputs[0])>=1 && int.Parse(inputs[0]) <= 100)
                    {
                        numerator = uint.Parse(inputs[0]);
                    }
                    if (int.Parse(inputs[1]) >= 1 && int.Parse(inputs[1]) <= 100)
                    {
                        denominator = uint.Parse(inputs[1]);
                        
                    }
                    numberOfDecimalPlace = uint.Parse(inputs[2]);
                    break;
                }
            }
            uint firstPart=numerator/denominator;
            uint numerator2=numerator-(firstPart*denominator);
            StringBuilder secondPart=new StringBuilder();
            for(int i=0;i<numberOfDecimalPlace; i++)
            {
                while (numerator2 <= denominator)
                {
                    numerator2 = numerator2 * 10;
                }

                uint res = numerator2 / denominator;
                secondPart.Append(res);
                numerator2=numerator2-(res*denominator);
            }
            Console.WriteLine("{0}.{1}",firstPart,secondPart);
            Console.ReadLine();
        }
    }
}
