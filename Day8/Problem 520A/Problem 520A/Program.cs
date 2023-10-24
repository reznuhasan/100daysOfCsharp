using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_520A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            string sentence;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                sentence = Console.ReadLine();
                int flag = 0;
                foreach(char ch in sentence)
                {
                    if ((Convert.ToInt32(ch) >= 65 && Convert.ToInt32(ch) <= 90) || (Convert.ToInt32(ch) >= 97 && Convert.ToInt32(ch) <= 122))
                    {
                        flag++;
                    }
                }
                if (flag == sentence.Length && sentence.Length==n && (n>=1 && n<=100))
                {
                    break;
                }
            }
            sentence = sentence.ToUpper();
            int[] arr = new int[26];
            foreach(char ch in sentence)
            {
                int value = ch - 'A';
                arr[value] = 1;
            }
            int count = 0;
            foreach(int num in arr)
            {
                if (num == 0)
                {
                    count = 1;
                }
            }
            if (count == 1)
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
