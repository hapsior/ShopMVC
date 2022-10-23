using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMVC.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }

        public Context(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Order>()
                .HasOne(p => p.Item).WithOne()
                .HasForeignKey<Item>(z => z.Id);

            builder.Entity<Order>()
                .HasOne(p => p.Customer).WithOne()
                .HasForeignKey<Customer>(z => z.Id);
            
        }
    }
}
