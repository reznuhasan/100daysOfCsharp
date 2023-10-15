using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_116A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if(n>=2 && n <= 1000)
                {
                    break;
                }
            }
            int stayPassenger = 0;
            int mostPassenger = 0;
            for(int i = 0; i < n; i++)
            {
                int exit;
                int enter;
                while (true)
                {
                    string sampleInput = Console.ReadLine();
                    string[] inputs = sampleInput.Split(' ');
                    exit = int.Parse(inputs[0]);
                    enter = int.Parse(inputs[1]);
                    if ((exit>=0 && exit<=1000) && (enter>=0 && enter <= 1000))
                     {
                         if(i==0 && exit == 0)
                        {
                            stayPassenger += enter;
                            break;
                        }
                        else if((i==n-1 && enter==0) && exit<=stayPassenger){
                            if (mostPassenger < stayPassenger)
                            {
                                mostPassenger = stayPassenger;
                            }
                            stayPassenger -= exit;
                            break;
                        }
                        else if((i!=0 || i!=n-1) && exit<=stayPassenger)
                        {
                            if (mostPassenger < stayPassenger)
                            {
                                mostPassenger = stayPassenger;
                            }
                            stayPassenger -= exit;
                            stayPassenger += enter;
                            break;
                        }
                     }

                }
            }
            Console.WriteLine("{0}",mostPassenger);
            Console.ReadLine();

        }
    }
}
