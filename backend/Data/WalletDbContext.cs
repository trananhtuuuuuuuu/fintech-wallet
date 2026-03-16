
using backend.Domain;
using Microsoft.EntityFrameworkCore;

namespace backend.Data;

public class WalletDbContext(DbContextOptions<WalletDbContext> options) : DbContext(options)
{
  public DbSet<User> Users { get; set; }
  public DbSet<Wallet> Wallets { get; set; }
  public DbSet<Transfer> Transfers { get; set; }
  public DbSet<ManagementWallet> ManagementWallets { get; set; }


  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<User>().HasKey(u => u.Id);
    modelBuilder.Entity<Wallet>().HasKey(w => w.Id);
    modelBuilder.Entity<Transfer>().HasKey(t => t.Id);
    modelBuilder.Entity<ManagementWallet>().HasKey(m => m.Id);

    // Configure User-Wallet relatPionship (One-to-Many)
    modelBuilder.Entity<User>()
      .HasMany(u => u.Wallets)
      .WithOne(w => w.User)
      .HasForeignKey(w => w.UserId)
      .OnDelete(DeleteBehavior.Cascade);

    modelBuilder.Entity<User>()
      .HasMany(u => u.ManagementWallets)
      .WithOne(m => m.User)
      .HasForeignKey(m => m.UserId)
      .OnDelete(DeleteBehavior.Cascade);

    // Configure table names (optional, for cleaner database)
    modelBuilder.Entity<User>().ToTable("Users");
    modelBuilder.Entity<Wallet>().ToTable("Wallets");
    modelBuilder.Entity<Transfer>().ToTable("Transfers");
    modelBuilder.Entity<ManagementWallet>().ToTable("ManagementWallets");

    // Add indexes for better performance
    modelBuilder.Entity<Wallet>()
      .HasIndex(w => w.UserId);
    
    modelBuilder.Entity<User>()
      .HasIndex(u => u.Email)
      .IsUnique();
  }

}