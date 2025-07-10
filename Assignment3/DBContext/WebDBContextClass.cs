using Microsoft.EntityFrameworkCore;
using Assignment3.Models;
using System;

namespace Assignment3.DBContext
{
    public class WebDBContextClass : DbContext
    {
        public WebDBContextClass(DbContextOptions<WebDBContextClass> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

    }
}
