using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictoinaryPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("Name", "Rizwan");
            dict.Add("Age", 25);
            dict.Add("Single", true);
            
            foreach(string key in dict.Keys)
            {
                Console.WriteLine(key+" : " + dict[key]);
            }
            Console.ReadLine();
        }
    }
}
