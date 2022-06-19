using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoney.Infrastructure.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>().HasKey(t => t.GroupId);
            modelBuilder.Entity<User>().HasKey(t => t.UserId);
            modelBuilder.Entity<Wallet>().HasKey(t => t.WalletId);
            modelBuilder.Entity<Category>().HasKey(t => t.CategoryId);
            modelBuilder.Entity<Transaction>().HasKey(t => t.TransactionId);
        }
    }
}
