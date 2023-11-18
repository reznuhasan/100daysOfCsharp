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
            }
            else if (num == 6)
            {
                return 1;
            }
            else if (num == 9)
            {
                return 2;
            }
            return num / 3;
        }
        public int calculateCol(int num, int raw)
        {
            return (num - (raw * 3)) - 1;
        }
        public bool checkGamePlayer1(int[] player)
        {
            int oneTwoThree = 0;
            int oneFourSeven = 0;
            int oneFiveNine = 0;
            int twoFiveEight = 0;
            int threeFiveSeven = 0;
            int threeSixNine = 0;
            int fourFiveSix = 0;
            int sevenEightNine = 0;
            for (int i = 0; i < player.Length; i++)
            {

                if (player[i] == 1)
                {
                    oneTwoThree++;
                    oneFourSeven++;
                    oneFiveNine++;
                }
                else if (player[i] == 2)
                {
                    oneTwoThree++;
                    twoFiveEight++;
                }
                else if (player[i] == 3)
                {
                    oneTwoThree++;
                    threeFiveSeven++;
                    threeSixNine++;
                }
                else if (player[i] == 4)
                {
                    oneFourSeven++;
                    fourFiveSix++;
                }
                else if (player[i] == 5)
                {
                    oneFiveNine++;
                    twoFiveEight++;
                    threeFiveSeven++;
                    fourFiveSix++;
                }
                else if (player[i] == 6)
                {
                    threeSixNine++;
                    fourFiveSix++;
                }
                else if (player[i] == 7)
                {
                    oneFourSeven++;
                    threeFiveSeven++;
                    sevenEightNine++;
                }
                else if (player[i] == 8)
                {
                    twoFiveEight++;
                    sevenEightNine++;
                }
                else if (player[i] == 9)
                {
                    oneFiveNine++;
                    threeSixNine++;
                    sevenEightNine++;
                }

            }
            if (oneTwoThree == 3 || oneFourSeven == 3 || oneFiveNine == 3 || twoFiveEight == 3 || threeFiveSeven == 3 || threeSixNine == 3 || fourFiveSix == 3 || sevenEightNine == 3)
            {

                return true;
            }
            return false;
        }
        public void GameBluePrint(char[,] arr)
        {
            Console.WriteLine("\t\t     |     |     ");
            Console.WriteLine("\t\t  {0}  |  {1}  |  {2}  ", arr[0, 0], arr[0, 1], arr[0, 2]);
            Console.WriteLine("\t\t_____|_____|_____");
            Console.WriteLine("\t\t     |     |     ");
            Console.WriteLine("\t\t  {0}  |  {1}  |  {2}  ", arr[1, 0], arr[1, 1], arr[1, 2]);
            Console.WriteLine("\t\t_____|_____|_____");
            Console.WriteLine("\t\t     |     |     ");
            Console.WriteLine("\t\t  {0}  |  {1}  |  {2}  ", arr[2, 0], arr[2, 1], arr[2, 2]);
            Console.WriteLine("\t\t     |     |     ");
        }

        static void Main(string[] args)
        {
            char[,] arr = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
            int[] player1 = new int[5];
            int playerOneCount = 0;
            int[] player2 = new int[5];
            int playerTwoCount = 0;
            bool gameOn = true;
            Console.WriteLine();
            Console.WriteLine("        ********Tic Tac Toe*********");
            Console.WriteLine("        ********Welcome to Our Game*********");
            Console.WriteLine();
            while (gameOn)
            {
                Program obj = new Program();
                obj.GameBluePrint(arr);
                //***********Player 1 part start****************
                while (true)
                {
                    Console.Write("Enter your position number player1:");
                    int num = int.Parse(Console.ReadLine());
                    if (num >= 1 && num < 10)
                    {
                        int raw = obj.calculateRaw(num);
                        int col = obj.calculateCol(num, raw);
                        if (arr[raw, col] != 'X' && arr[raw, col] != 'O')
                        {
                            arr[raw, col] = 'O';
                            player1[playerOneCount] = num;
                            bool win = obj.checkGamePlayer1(player1);

                            if (win == true)
                            {
                                obj.GameBluePrint(arr);
                                Console.WriteLine("Hurrrrrey!!! You Win The Matche");
                                gameOn = false;
                            }
                            playerOneCount++;
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
                if (gameOn == false)
                {
                    break;
                }
                if (playerOneCount + playerTwoCount == 9)
                {
                    obj.GameBluePrint(arr);
                    Console.WriteLine("Match Tied.No one win the match");
                }
                else
                {
                    obj.GameBluePrint(arr);
                }
                //****************player2 part start***********
                while (true)
                {
                    Random random = new Random();
                    int num = random.Next(1, 10);
                    if (num >= 1 && num < 10)
                    {
                        int raw = obj.calculateRaw(num);
                        int col = obj.calculateCol(num, raw);
                        if (arr[raw, col] != 'X' && arr[raw, col] != 'O')
                        {
                            Console.WriteLine("Computer Selected Position number:{0}", num);
                            arr[raw, col] = 'X';
                            player2[playerTwoCount] = num;
                            bool win = obj.checkGamePlayer1(player2);
                            if (win == true)
                            {
                                obj.GameBluePrint(arr);
                                Console.WriteLine("Bad Luck :< You lost The match");
                                gameOn = false;
                            }
                            playerTwoCount++;
                            break;
                        }
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
