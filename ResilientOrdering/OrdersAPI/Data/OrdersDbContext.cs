using DataModels.Data.Tables;
using Microsoft.EntityFrameworkCore;

namespace OrdersAPI.Data
{
    public class OrdersDbContext(DbContextOptions<OrdersDbContext> options) : DbContext(options)
    {
        public DbSet<Order> Orders { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Order>(entity =>
        //    {
        //        entity.HasKey(e => e.Id);
        //        entity.Property(e => e.Id).ValueGeneratedNever();
        //        entity.Property(e => e.)
        //    });
        //}
    }
}
