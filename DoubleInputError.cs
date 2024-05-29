using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class DoubleInputError : UserError
    {
        protected override string UEMessage()
        {
            return "You tried to use a text input in a double only field. This fired an error!";
        }
    }
}
