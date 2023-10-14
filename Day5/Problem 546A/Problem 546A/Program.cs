using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_546A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint firstPrice;
            uint initialBalance;
            uint totalBanana;
            while (true)
            {
                string numbers;
                numbers = Console.ReadLine();
                int count = 0;
                foreach(char number in numbers)
                {
                    if((Convert.ToInt32(number)>=48 && Convert.ToInt32(number) <= 57) || number==' ')
                    {
                        count++;
                    }
                }
                string[] newNumbers = numbers.Split(' ');
                firstPrice = uint.Parse(newNumbers[0]);
                initialBalance = uint.Parse(newNumbers[1]);
                totalBanana = uint.Parse(newNumbers[2]);
                if (numbers.Length == count && (firstPrice>=1 && firstPrice<=1000) && (totalBanana >= 1 && totalBanana <= 1000) && (initialBalance >= 0 && initialBalance <= 1000000000)){
                    break;
                }
            }
            uint totalCost = 0;
            for(uint i = 1; i <=totalBanana; i++)
            {
                totalCost += (firstPrice * i);
            }

            int borrow =  (int)totalCost-(int)initialBalance;
            borrow = (borrow <= 0 ? 0 : borrow);
            Console.WriteLine("{0}",borrow);
            Console.ReadLine();
        }
    }
}
