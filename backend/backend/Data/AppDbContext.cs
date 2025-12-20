using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Tables
        public DbSet<User> Users { get; set; }
        public DbSet<Tasting> Tastings { get; set; }



        // Config
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User
            modelBuilder.Entity<User>(entity =>
            {
                // unique
                entity.HasIndex(u => u.Email).IsUnique();

                // required
                entity.Property(u => u.Email).IsRequired();
                entity.Property(u => u.PasswordHash).IsRequired();
            });

            // Tasting
            modelBuilder.Entity<Tasting>(entity =>
            {
                // decimal point
                entity.Property(t => t.Price)
                      .HasColumnType("decimal(18,2)");

                // Relation
                entity.HasOne(t => t.User)
                      .WithMany(u => u.Tastings)
                      .HasForeignKey(t => t.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

        }
    }


}

