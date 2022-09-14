using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Data
{
    public class AppDbContext:DbContext
    {

        //public DbSet<Manager> managers { get; set; }
        //public DbSet<Employee> employees { get; set; }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<ProductFeature> productFeatures { get; set; }
        public DbSet<ProductEssential> ProductEssentials { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Initializer.Build();
            optionsBuilder.UseSqlServer(Initializer.Configuration.GetConnectionString("sqlCon"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            
            
            
            
            //modelBuilder.Entity<Product>().Property(x=>x.IsDeleted).HasDefaultValue(false);
            //modelBuilder.Entity<Product>().HasQueryFilter(x => x.IsDeleted == false);
            //modelBuilder.Entity<Product>().HasQueryFilter(x => x.Stock == Stock);
            //modelBuilder.Entity<Product>().ToSqlQuery("Select * from Products");
            //modelBuilder.Entity<Manager>().OwnsOne(x => x.person, y =>
            //{
            //    y.Property(x => x.firstName).HasColumnName("FirstName");
            //    y.Property(x => x.lastName).HasColumnName("LastName");
            //    y.Property(x => x.age).HasColumnName("Age");
            //});
            //modelBuilder.Entity<Employee>().OwnsOne(x => x.person, y =>
            //{
            //    y.Property(x => x.firstName).HasColumnName("FirstName");
            //    y.Property(x => x.lastName).HasColumnName("LastName");
            //    y.Property(x => x.age).HasColumnName("Age");
            //});
        }
    }
}
