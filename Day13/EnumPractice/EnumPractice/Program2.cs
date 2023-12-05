using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice
{
    public enum Months
    {
        January,
        Feburary,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December,
        
    }
    public class Program2
    {
        static void Main(string[] args)
        {
            foreach (int month in Enum.GetValues(typeof(Months))){
                Console.WriteLine(month +":"+(Months)month);
            }
            foreach(string month in Enum.GetNames(typeof(Months)))
            {
                Console.WriteLine(month);
            }
            Console.ReadLine();
        }
        
    }
}
