using BahiaImperial_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BahiaImperial_API.Data.Configurations
{
    public class LoanConfiguration
    {
        public void Configure(EntityTypeBuilder<Loan> loan)
        {
            loan.ToTable("loans");

            loan.Property(l => l.AccountId)
                .IsRequired();

            loan.Property(l => l.Initial_Loan)
                .HasPrecision(15, 2)
                .IsRequired();

            loan.Property(l => l.Current_Loan)
                .HasPrecision(15, 2)
                .IsRequired();

            loan.Property(l => l.Loan_Status)
                .HasMaxLength(7)
                .IsRequired();

            loan.Property(l => l.Created_At)
                .HasColumnType("timestamp")
                .HasPrecision(3)
                .IsRequired();
        }
    }
}
