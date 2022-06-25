﻿using System;
using System.Collections.Generic;

namespace Crm_BL.Model
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Check> Checks { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
