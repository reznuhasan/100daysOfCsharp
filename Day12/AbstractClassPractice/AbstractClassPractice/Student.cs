using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPractice
{
    public class Student:Person
    {
        public override string password(string pass)
        {
            return pass;
        }

        static void Main(string[] args)
        {
            Student student = new Student();
            student.Test("Student");
            Console.ReadLine();
        }
    }
}
