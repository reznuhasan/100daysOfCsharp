using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_In_GenericList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Rizwan",1234,"Student",25);
            Person person2 = new Person("Asif", 1235, "Student", 25);
            Person person3 = new Person("Tonoy", 1236, "Student", 25);
            Person person4 = new Person("Ajad Munshi", 1237, "Teacher", 25);

            List<Person> li = new List<Person>();
            li.Add(person1);
            li.Add(person2);
            li.Add(person3);
            li.Add(person4);

            foreach (Person p in li)
            {
                Console.WriteLine(p.Name + " : " + p.Title);
            }
            Console.ReadLine();
        }
    }
}
