using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice
{
    public enum Foods
    {
        Apple=250,Orange=300,Watermelon=120,Pineapple=50
    }
    public class Program3
    {
        static void Main(string[] args)
        {
            foreach(int food in Enum.GetValues(typeof(Foods)))
            {
                Console.WriteLine((Foods)food+" : "+food+"tk");
            }
            Console.ReadLine();
        }
    }
}
