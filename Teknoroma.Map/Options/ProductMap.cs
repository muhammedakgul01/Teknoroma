using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teknoroma.Entities;

namespace Teknoroma.Map.Options
{
    public class ProductMap : BaseMap<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);

            builder.HasIndex(x => x.Barcode)
                .IsUnique();

            builder.Property(x => x.UnitPrice)
                .HasPrecision(18, 2);
        }
    }
}