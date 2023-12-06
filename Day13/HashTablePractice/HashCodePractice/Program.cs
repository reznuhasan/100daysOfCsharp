using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashCodePractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Name", "Rizwan Hasan");
            ht.Add("Age", 25);
            ht.Add("Single", true);
            ht.Remove("Age");
            ht.Clear();
            ht.Add("Id", "123456");
            
            foreach(string key in ht.Keys)
            {
                Console.WriteLine(ht[key]);
            }
            Console.ReadLine();

        }
    }
}
