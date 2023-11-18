using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    internal class Program
    {
        public int calculateRaw(int num)
        {
            if (num == 3)
            {
                return 0;
            }else if(num == 6)
            {
                return 1;
            }else if(num == 9)
            {
                return 2;
            }
            return num / 3;
        }
        public int calculateCol(int num,int raw)
        {
            return (num - (raw * 3))-1;
        }
      
        static void Main(string[] args)
        {
            char[,] arr = { { '1', '2', '3'}, { '4', '5', '6' }, { '7', '8', '9' } };
            Console.WriteLine();
            Console.WriteLine("        ********Tic Tac Toe*********");
            Console.WriteLine("        ********Welcome to Our Game*********");
            Console.WriteLine();
            while (true) {
                Console.WriteLine("\t\t     |     |     ");
                Console.WriteLine("\t\t  {0}  |  {1}  |  {2}  ", arr[0, 0], arr[0, 1], arr[0, 2]);
                Console.WriteLine("\t\t_____|_____|_____");
                Console.WriteLine("\t\t     |     |     ");
                Console.WriteLine("\t\t  {0}  |  {1}  |  {2}  ", arr[1, 0], arr[1, 1], arr[1, 2]);
                Console.WriteLine("\t\t_____|_____|_____");
                Console.WriteLine("\t\t     |     |     ");
                Console.WriteLine("\t\t  {0}  |  {1}  |  {2}  ", arr[2, 0], arr[2, 1], arr[2, 2]);
                Console.WriteLine("\t\t     |     |     ");
                while (true)
                {
                    Console.Write("Enter your position number:");
                    int num = int.Parse(Console.ReadLine());
                    Program obj= new Program();
                    if (num < 10)
                    {
                        int raw = obj.calculateRaw(num);
                        int col = obj.calculateCol(num, raw);
                        if (arr[raw, col] != 'X' && arr[raw, col] != 'O')
                        {
                            arr[raw, col] = 'O';
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Position are already fulfilled.:< Please try again");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Number :(.Please Try Again");
                    }
                    
                    

                }
            }
            Console.ReadLine();
        }
    }
}
