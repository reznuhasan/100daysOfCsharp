using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_785A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if(n>=1 && n<= 200000)
                {
                    break;
                }
            }
            int flag = 0;
            long count = 0;
            while (flag < n)
            {
                string sentence = Console.ReadLine();
                if(sentence== "Tetrahedron")
                {
                    count += 4;
                    flag++;
                }else if(sentence== "Cube")
                {
                    count += 6;
                    flag++;
                }else if(sentence== "Octahedron")
                {
                    count += 8;
                    flag++;
                }else if(sentence== "Dodecahedron")
                {
                    count += 12;
                    flag++;
                }else if(sentence== "Icosahedron")
                {
                    count += 20;
                    flag++;
                }
            }
            Console.WriteLine("{0}",count);
            Console.ReadLine();
        }
    }
}
