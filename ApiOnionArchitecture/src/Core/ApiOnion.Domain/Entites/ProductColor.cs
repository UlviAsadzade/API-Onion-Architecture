using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiOnion.Domain.Entites
{
    public class ProductColor :BaseEntity
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int ColorId { get; set; }

        public Color Color { get; set; }
    }
}
