using BahiaImperial_API.Models.BankAccounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BahiaImperial_API.Data.Configurations
{
    public class AccountConfiguration
    {
        public void Configure(EntityTypeBuilder<Account> account)
        {
            account.ToTable("accounts");

            account.Property(a => a.Id)
                .IsRequired();

            account.Property(a => a.Type)
                .HasMaxLength(8);

            account.Property(a => a.Balance)
                .HasPrecision(15, 2);

            account.Property(a => a.LoanLimit)
                .HasPrecision(15, 2);

        }
    }
}