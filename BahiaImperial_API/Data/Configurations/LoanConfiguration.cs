using BahiaImperial_API.Models;
using BahiaImperial_API.Models.BankAccounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BahiaImperial_API.Data.Configurations
{
    public class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> loan)
        {
            loan.ToTable("loans");

            loan.HasKey(l => l.Id);

            loan.Property(l => l.AccountId)
                .IsRequired()
                .ValueGeneratedOnAdd();

            loan.Property(l => l.InitialLoan)
                .HasPrecision(15, 2)
                .IsRequired();

            loan.Property(l => l.CurrentLoan)
                .HasPrecision(15, 2)
                .IsRequired();

            loan.Property(l => l.LoanStatus)
                .HasMaxLength(7)
                .IsRequired();

            loan.Property(l => l.CreatedAt)
                .HasColumnType("timestamp")
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasPrecision(3)
                .IsRequired();
        }
    }
}
