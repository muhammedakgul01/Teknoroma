/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Teknoroma.DataAccess.Context
{
    public class TeknoromaDbContextFactory : IDesignTimeDbContextFactory<TeknoromaDbContext>
    {
        public TeknoromaDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TeknoromaDbContext>();
            optionsBuilder.UseSqlServer(
                "Server=localhost,1433;Database=TeknoromaDb;User Id=sa;Password=reallyStrongPwd123;TrustServerCertificate=True;");

            return new TeknoromaDbContext(optionsBuilder.Options);
        }

    }
}
*/