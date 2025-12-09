using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Options;
using Teknoroma.Entities;

namespace Teknoroma.Map.Options
{
    public class ProductOfOrderMap : BaseMap<ProductOfOrder>
    {
        public override void Configure(EntityTypeBuilder<ProductOfOrder> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new
            {
                x.ProductID,
                x.OrderID
            });

            builder.HasOne(o => o.Order)
        .WithMany(c => c.ProductOfOrders)
        .HasForeignKey(o => o.OrderID)
        .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(o => o.Product)
        .WithMany(c => c.ProductOfOrders)
        .HasForeignKey(o => o.ProductID)
        .OnDelete(DeleteBehavior.Restrict);

        }
    }
}