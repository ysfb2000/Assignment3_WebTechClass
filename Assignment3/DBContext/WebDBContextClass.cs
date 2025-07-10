using Microsoft.EntityFrameworkCore;

namespace Assignment3.DBContext
{
    public class WebDBContextClass : DbContext
    {
        public WebDBContextClass(DbContextOptions<WebDBContextClass> options) : base(options)
        {
        }

        //public DbSet<Models.Users> Users { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Models.Users>().ToTable("Users");
        //    base.OnModelCreating(modelBuilder);
        //}

    }
}
