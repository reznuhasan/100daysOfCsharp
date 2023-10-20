using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_110A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long myValue;
            while (true)
            {
                myValue = long.Parse(Console.ReadLine());
                if (myValue >= 1 && myValue <= 1000000000000000000)
                {
                    break;
                }
            }
            int flag = 0;
            int totalFlag = 0;
            while (myValue > 0)
            {
                int reminder = (int)(myValue % 10);
                if(reminder==4 || reminder == 7)
                {
                    flag++;
                }
                totalFlag++;
                myValue /= 10;
            }
            if (flag > 0)
            {
                int count = 0;
                int countNo = 0;
                while (flag > 0)
                {
                    int value = flag % 10;
                    if(value==4 || value == 7)
                    {
                        count++;
                    }
                    countNo++;
                    flag /= 10;
                }
                if (count == countNo)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();

        }
    }
}
