using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Swan : Bird
    {
        protected bool _hasAdorableChicks;
        public Swan(string name, int age, double weight, bool hasAdorableChicks) : base(name, age, weight)
        {
            _hasAdorableChicks = hasAdorableChicks;
        }

        public override string Stats()
        {
            return $"{_name}, Age: {_age}, {_weight}kg, it is {_hasAdorableChicks} that cygnets are adorable.";
        }

        public override void DoSound()
        {
            Console.WriteLine("Honk!");
        }
    }
}
