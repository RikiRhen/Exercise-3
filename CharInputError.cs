using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class CharInputError : UserError
    {
        protected override string UEMessage()
        {
            return "You tried to use multiple letters in a single-character only field. This fired an error!";
        }
    }
}
