using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Teknoroma.DataAccess.Configurations;
using Teknoroma.Entities;
using Teknoroma.Map.Options;

namespace Teknoroma.DataAccess.Context
{
    public class TeknoromaDbContext : DbContext
    {
        public TeknoromaDbContext(DbContextOptions<TeknoromaDbContext> options) : base(options)
        {
        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CashRegisterMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new EmployeeMap());
            modelBuilder.ApplyConfiguration(new OrderMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new ProductOfOrderMap());
            modelBuilder.ApplyConfiguration(new ProductOfStoreMap());
            modelBuilder.ApplyConfiguration(new StoreMap());
            modelBuilder.ApplyConfiguration(new SupplierMap());
        }

        public DbSet<CashRegister> CashRegisters { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOfOrder> ProductOfOrders { get; set; }
        public DbSet<ProductOfStore> ProductOfStores { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}