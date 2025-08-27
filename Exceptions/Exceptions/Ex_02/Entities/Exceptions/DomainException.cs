﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02.Entities.Exceptions
{
    class DomainException : ApplicationException
    {

        public DomainException(string message) : base(message)
        {

        }
    }
}
