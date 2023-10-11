using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your password:");
                string password = Console.ReadLine();
                if (password.Length <= 8)
                {
                    Console.WriteLine("Password must be more than 8 character");
                }
                else
                {
                    int upper = 0;
                    int lower = 0;
                    int num = 0;
                    int special = 0;
                    foreach (char letter in password)
                    {
                        if (letter >= 65 && letter <= 90)
                        {
                            upper++;
                        }
                        if (letter >= 97 && letter <= 122)
                        {
                            lower++;
                        }
                        if (letter >= 49 && letter <= 58)
                        {
                            num++;
                        }
                        if ((letter >= 32 && letter <= 47) || (letter >= 58 && letter <= 64) || (letter >= 91 && letter <= 96) || (letter >= 123 && letter <= 126))
                        {
                            special++;
                        }
                    }
                    if (upper == 0)
                    {
                        Console.WriteLine("Use a upper lettr (A-Z)");
                    }
                    else if (lower == 0)
                    {
                        Console.WriteLine("Use a lower letter (a-z)");
                    }
                    else if (num == 0)
                    {
                        Console.WriteLine("Use a number (0-9)");
                    }
                    else if (special == 0)
                    {
                        Console.WriteLine("Use a special character");
                    }
                    else
                    {
                        Console.WriteLine("Password create a successfully");
                        if (password.Length > 12)
                        {
                            Console.WriteLine("Quality:- Good");
                            break;
                        }
                        else if (special > 3)
                        {
                            Console.WriteLine("Quality:- Good");
                            break;
                        }
                        else if (special > 3 && password.Length > 12)
                        {
                            Console.WriteLine("Quality:- Excellent");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Quality:- Average");
                            break;
                        }
                    }
                }
            }
            
            Console.ReadLine();
        }
    }
}
