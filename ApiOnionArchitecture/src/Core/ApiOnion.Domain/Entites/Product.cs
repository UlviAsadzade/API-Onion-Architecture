using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiOnion.Domain.Entites
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public string Image { get; set; }

        public string? Description { get; set; }

        public decimal CostPrice { get; set; }

        public decimal SalePrice { get; set; }

        public decimal Discount { get; set; }

        public int Count { get; set; }

        //Relational Properties

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public List<ProductColor> ProductColors { get; set; }
    }
}
