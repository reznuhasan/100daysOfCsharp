﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExample
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cgpa { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
