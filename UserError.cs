using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly:InternalsVisibleTo("Program")]
namespace Exercise_3
{
    internal abstract class UserError
    {
        public abstract string UEMessage();
    }
}
