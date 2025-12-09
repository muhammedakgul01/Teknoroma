using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities;

namespace Teknoroma.Map.Options
{
    public class CategoryMap : BaseMap<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);

            builder.HasOne(o => o.ParentCategory)
        .WithMany(c => c.ChildCategories)
        .HasForeignKey(o => o.ParentCategoryID)
        .OnDelete(DeleteBehavior.Restrict);
        }
    }
}