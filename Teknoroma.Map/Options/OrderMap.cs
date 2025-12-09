using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities;

namespace Teknoroma.Map.Options
{
    public class OrderMap : BaseMap<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
                builder.HasOne(o => o.Store)
        .WithMany(c => c.Orders)
        .HasForeignKey(o => o.StoreID)
        .OnDelete(DeleteBehavior.Restrict);
        
            base.Configure(builder);
            builder.HasOne(o => o.Employee)
        .WithMany(e => e.Orders)
        .HasForeignKey(o => o.EmployeeID)
        .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(o => o.CashRegister)
            .WithMany(e => e.Orders)
            .HasForeignKey(o => o.CashRegisterID)
            .OnDelete(DeleteBehavior.Restrict);
        
            builder.HasOne(o => o.Customer)
        .WithMany(c => c.Orders)
        .HasForeignKey(o => o.CustomerID)
        .OnDelete(DeleteBehavior.Restrict);
        }

    }
}