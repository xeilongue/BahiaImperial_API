using Microsoft.EntityFrameworkCore;
using BahiaImperial_API.Models;

namespace BahiaImperial_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Clients> Clients { get; set; }
    }

}
