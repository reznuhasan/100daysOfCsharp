using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_96A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string players;
            while (true)
            {
                players = Console.ReadLine();
                int count = 0;
                int teamZero = 0;
                int teamOne= 0;
                foreach(char player in players)
                {
                    if(player=='0')
                    {
                        teamZero++;
                        count++;
                    }
                    if (player == '1')
                    {
                        teamOne++;
                        count++;
                    }
                }
                if(teamOne>0 && teamZero>0 && players.Length==count && players.Length <= 100)
                {
                    break;
                }
            }
            int playerCount = 1;
            for(int i = 0; i < players.Length-1; i++)
            {
                if (players[i] == players[i + 1])
                {
                    playerCount++;
                }
                else
                {
                    if (playerCount >= 7)
                    {
                        break;
                    }
                    else
                    {
                        playerCount = 1;
                    }
                }
            }
            if (playerCount >= 7)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
        }

        
    }
}
