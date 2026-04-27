using BahiaImperial_API.Models;
using BahiaImperial_API.Models.BankAccounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BahiaImperial_API.Data.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> transaction)
        {
            transaction.ToTable("transactions");

            transaction.HasKey(t => t.Id);

            transaction.Property(t => t.Id)
                .IsRequired();

            transaction.Property(t => t.Type)
                .HasMaxLength(14)
                .IsRequired();

            transaction.Property(t => t.Amount)
                .HasPrecision(15, 2)
                .IsRequired();

            transaction.Property(t => t.TrDate)
                .HasColumnType("timestamp")
                .HasPrecision(3)
                .IsRequired();
        }
    }
}
