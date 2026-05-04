using BahiaImperial_API.Models;
using BahiaImperial_API.Models.BankAccounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BahiaImperial_API.Data.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> account)
        {
            account
                .UseTphMappingStrategy()
                .ToTable("accounts");

            account.HasKey(a => a.Id);

            account.Property(a => a.Id)
                .IsRequired();

            account.Property(a => a.Balance)
                .HasPrecision(15, 2);

            account.Property(a => a.LoanLimit)
                .HasPrecision(15, 2);

            account.Property(a => a.Type)
                .HasConversion<string>()
                .HasMaxLength(13)
                .IsRequired()
                .HasColumnOrder(2);

            account.HasDiscriminator(a => a.Type)
                .HasValue<Business>(Account.AccountType.business)
                .HasValue<Checking>(Account.AccountType.checking)
                .HasValue<Saving>(Account.AccountType.saving);

            account.HasMany(a => a.Transactions)
                .WithOne()
                .HasForeignKey(t => t.AccountId)
                .IsRequired();

            account.HasMany(a => a.Loans)
                .WithOne()
                .HasForeignKey(l => l.AccountId)
                .IsRequired();

        }
    }
}