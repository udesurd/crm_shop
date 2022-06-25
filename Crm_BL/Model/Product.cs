using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm_BL.Model
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; } 
        public decimal Weight { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
