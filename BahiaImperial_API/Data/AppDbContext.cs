using Microsoft.EntityFrameworkCore;
using BahiaImperial_API.Models;
using BahiaImperial_API.Models.BankAccounts;

namespace BahiaImperial_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Client> clients { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Account> accounts { get; set; }
        public DbSet<Transaction> transactions { get; set; }
        public DbSet<Loan> loans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



        }

    }

}
