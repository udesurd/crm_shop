using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm_BL.Model
{
    internal class Check
    {
        public int CheckId { get; set; }
        public string CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

    }
}
