using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Pelican : Bird
    {
        protected bool _gularPouch;
        public Pelican(string name, int age, double weight, bool gularPouch) : base(name, age, weight)
        {
            _gularPouch = gularPouch;
        }

        public override string Stats()
        {
            return $"{_name}, Age: {_age}, {_weight}kg, it is {_gularPouch} that this bird has a gular pouch.";
        }
    }
}
