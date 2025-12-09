using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities;

namespace Teknoroma.Map.Options
{
    public class ProductOfStoreMap : BaseMap<ProductOfStore>
    {
        public override void Configure(EntityTypeBuilder<ProductOfStore> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new
            {
                x.ProductID,
                x.StoreID
            });

            builder.HasOne(o => o.Store)
        .WithMany(c => c.ProductOfStores)
        .HasForeignKey(o => o.StoreID)
        .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(o => o.Product)
        .WithMany(c => c.ProductOfStores)
        .HasForeignKey(o => o.ProductID)
        .OnDelete(DeleteBehavior.Restrict);

        }
    }
}