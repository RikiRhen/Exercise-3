using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Wolfman : Wolf, IPerson
    {
        protected bool _isBipedal;
        public Wolfman(string name, int age, double weight, bool isBipedal) : base(name, age, weight)
        {
            _isBipedal = isBipedal;
        }

        public void Talk()
        {
            Console.WriteLine("AwooOoOOo I say!");
        }

    }
}
