﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Rizwan", "Hasan");
            person.getName();
            person.getName(",");
            Console.ReadLine();
        }
    }
}