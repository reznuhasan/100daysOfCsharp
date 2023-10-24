using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_141A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string guest;
            string host;
            string pie;
            while (true)
            {
                guest = Console.ReadLine();
                host = Console.ReadLine();
                pie = Console.ReadLine();
                int guestCount = 0;
                int hostCount = 0;
                int pieCount = 0;
                foreach(char ch in guest)
                {
                    if(Convert.ToInt32(ch)>=65 && Convert.ToInt32(ch) <= 90)
                    {
                        guestCount++;
                    }
                }
                foreach (char ch in host)
                {
                    if (Convert.ToInt32(ch) >= 65 && Convert.ToInt32(ch) <= 90)
                    {
                        hostCount++;
                    }
                }
                foreach (char ch in pie)
                {
                    if (Convert.ToInt32(ch) >= 65 && Convert.ToInt32(ch) <= 90)
                    {
                        pieCount++;
                    }
                }
                if(guestCount==guest.Length && (guestCount>=1 && guestCount<=100) && pieCount == pie.Length && (pieCount >= 1 && pieCount <= 100) && hostCount == host.Length && (hostCount >= 1 && hostCount <= 100))
                {
                    break;
                }
            }
            int[] twoNameCount = new int[26];
            string twoName = guest + host;
            foreach(char ch in twoName)
            {
                int value = ch - 'A';
                twoNameCount[value]++;
            }
            int[] pieNameCount = new int[26];
            foreach(char ch in pie)
            {
                int value = ch - 'A';
               pieNameCount[value]++;
            }
            int flag = 0;
            for(int i = 0; i < 26; i++)
            {
                if (twoNameCount[i] != pieNameCount[i])
                {
                    flag = 1;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
            Console.ReadLine();
        }
    }
}
