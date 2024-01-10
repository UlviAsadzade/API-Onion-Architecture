using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiOnion.Domain.Entites
{
    public class Color : BaseEntity
    {
        public string Name { get; set; }
        public List<ProductColor> ProductColors { get; set; }

    }
}
