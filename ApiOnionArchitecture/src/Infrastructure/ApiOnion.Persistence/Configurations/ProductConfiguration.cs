using ApiOnion.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiOnion.Persistence.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.CostPrice).IsRequired().HasColumnType("decimal(10,2)");
            builder.Property(p => p.SalePrice).IsRequired().HasColumnType("decimal(10,2)");
            builder.Property(p => p.Discount).IsRequired().HasColumnType("decimal(10,2)");
            builder.Property(p => p.Description).IsRequired(false).HasColumnType("text");
            builder.Property(p => p.Code).IsRequired().HasMaxLength(100);
        }
    }
}
