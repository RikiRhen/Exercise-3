using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class EmptyInputError : UserError
    {
        protected override string UEMessage()
        {
            return "You tried to leave an obligatory field empty. This fired an error!";
        }
    }
}
