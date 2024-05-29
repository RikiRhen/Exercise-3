using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Flamingo : Bird
    {
        protected int _standsOnNumberOfLegs;
        public Flamingo(string name, int age, double weight, int standsOnNumberOfLegs) : base(name, age, weight)
        {
            _standsOnNumberOfLegs = standsOnNumberOfLegs;
        }
    }
}
