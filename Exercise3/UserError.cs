﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly:InternalsVisibleTo("Exercise3.Tests")]

namespace Exercise_3
{
    internal abstract class UserError
    {
        protected abstract string UEMessage();
        public string GetMessage() { return UEMessage(); }
    }
}
