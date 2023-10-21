using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Constructor1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PerameterCon obj = new PerameterCon();
            PerameterCon obj1 = new PerameterCon();
            Person per = new Person("Rizwan", 25);
            per.showDetails();
            Student student1 = new Student("Afridul", 123);
            Student student2 = new Student(student1);
            student2.ShowDetails();
            Console.ReadLine();
        }
    }
}
