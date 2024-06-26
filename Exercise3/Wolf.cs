﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Wolf : Animal
    {
        public Wolf(string name, int age, double weight) : base(name, age, weight)
        {
        }
        public override string Stats()
        {
            return $"{_name}, Age: {_age}, {_weight}kg.";
        }

        public override string DoSound()
        {
            return "Awoo!";
        }
    }
}
