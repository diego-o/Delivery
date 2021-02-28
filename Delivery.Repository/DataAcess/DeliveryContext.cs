using Delivery.Entities.Register;
using Delivery.Repository.DataAcess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Repository.DataAcess
{
    public class DeliveryContext : DbContext, IDeliveryContext
    {
        public DeliveryContext(DbContextOptions<DeliveryContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("tb_user");
            modelBuilder.Entity<User>().HasKey(t => t.Id);

            modelBuilder.Entity<User>().Property(t => t.Email)
                                       .HasColumnName("email")
                                       .HasMaxLength(200);
            modelBuilder.Entity<User>().Property(t => t.Id)
                                       .HasColumnName("id");
            modelBuilder.Entity<User>().Property(t => t.Name)
                                       .HasColumnName("name")
                                       .HasMaxLength(100);
            modelBuilder.Entity<User>().Property(t => t.Password)
                                       .HasColumnName("password");
        }
    }
}
