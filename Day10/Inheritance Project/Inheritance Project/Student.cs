using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Project
{
    internal class Student:Inheritance_Project.Person
    {
        public string major;
        private float gpa;
        private string DOB;
        private int level;
        private string exActivity;
        static void Main()
        {
            Student st = new Student();
            
        }
    }
}
