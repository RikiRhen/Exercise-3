using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal abstract class Animal
    {
        protected string _name;
        protected int _age;
        protected double _weight;

        public Animal(string name, int age, double weight)
        {
            _name = name;
            _age = age;
            _weight = weight;
        }

        protected abstract void DoSound();
    }
}
