using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferencePracticeRecap
{
    public class Employee:Person
    {
        string Salary { get; set; }
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.Name = "Alif";
            obj.Salary = "40000";
            Console.WriteLine("{0} monthly Salary {1}",obj.Name,obj.Salary);
        }

    }
}
