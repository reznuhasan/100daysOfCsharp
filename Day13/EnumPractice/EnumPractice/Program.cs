using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice
{
    public enum Days
    {
        saturday,
        sunday,
        monday,
        tuesday,
        wednesday,  
        thursday,
        friday
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Days d = (Days)2;
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
