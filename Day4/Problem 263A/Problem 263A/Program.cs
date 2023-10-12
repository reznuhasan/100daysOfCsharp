using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_263A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[5, 5];
            for(int i = 0; i < 5; i++)
            {
                string[] userInput = Console.ReadLine().Split(' ');
                for(int j = 0; j < 5; j++)
                {
                    if (userInput.Length > j)
                    {
                        mat[i,j]=int.Parse(userInput[j]); 
                    }
                }  
            }
            int col=0,row=0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (mat[i, j] == 1)
                    {
                        col = j+1;
                        row = i+1;
                    }
                }
            }
            int count = 0;
            if (row > 3)
            {
                count += (row - 3);
            }
            else if (row < 3){
                count += (3 - row);
            }
            if (col > 3)
            {
                count += (col - 3);
            }
            else if (col < 3){
                count += (3 - col);
            }
            Console.WriteLine("{0}",count);
            Console.ReadLine();
        }
    }
}
