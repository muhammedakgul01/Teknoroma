using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Teknoroma.Entities;

namespace Teknoroma.Map.Options
{
    public class CashRegisterMap : BaseMap<CashRegister>
    {
        public override void Configure(EntityTypeBuilder<CashRegister> builder)
        {
            base.Configure(builder);
            builder.HasOne(o => o.Store)
        .WithMany(c => c.CashRegisters)
        .HasForeignKey(o => o.StoreID)
        .OnDelete(DeleteBehavior.Restrict);
        }
    }
}