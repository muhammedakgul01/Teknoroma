using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities;

namespace Teknoroma.Map.Options
{
    public class EmployeeMap : BaseMap<Employee>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            base.Configure(builder);
            builder.HasOne(o => o.Store)
        .WithMany(c => c.Employees)
        .HasForeignKey(o => o.StoreID)
        .OnDelete(DeleteBehavior.Restrict);
        }
    }
}