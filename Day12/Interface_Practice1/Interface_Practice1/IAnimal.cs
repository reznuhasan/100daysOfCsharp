﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practice1
{
    internal interface IAnimal
    {
        string Name { get; }
        void MakeSound();
        string PerformAction(string action);
    }
}
