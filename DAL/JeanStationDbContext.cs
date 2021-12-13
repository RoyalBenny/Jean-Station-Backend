using JeanStationModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL
{
    public class JeanStationDbContext:DbContext
    {

        public JeanStationDbContext() { }
        public JeanStationDbContext(DbContextOptions<JeanStationDbContext> options): base(options) {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }

    }
}
