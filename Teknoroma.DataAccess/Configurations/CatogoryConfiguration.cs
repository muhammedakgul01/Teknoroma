using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Teknoroma.Entities;

namespace Teknoroma.DataAccess.Configurations
{
    public class CatogoryConfiguration :  BaseEntityConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);

            builder.HasOne(k => k.ParentCategory)
            .WithMany(k => k.ChildCategories)
            .HasForeignKey(k => k.ParentCategoryID)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}