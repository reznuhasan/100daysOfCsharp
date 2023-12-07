using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_In_GenericList
{
    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public int Age {  get; set; }
        public Person(string name, int id, string title, int age)
        {
            Name = name;
            Id = id;
            Title = title;
            Age = age;
        }
    }
}
