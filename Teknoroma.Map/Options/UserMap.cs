using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teknoroma.Entities;

namespace Teknoroma.Map.Options
{
    public class UserMap : BaseMap<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.UserName)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(x => x.UserName)
                .IsUnique();

            builder.Property(x => x.PasswordHash)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(x => x.PasswordSalt)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(x => x.isLocked)
                .IsRequired();

            builder.HasOne(x => x.Employee)
                .WithOne(x => x.User)
                .HasForeignKey<User>(x => x.EmployeeID);
        }
    }
}
