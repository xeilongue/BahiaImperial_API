using BahiaImperial_API.Models;
using BahiaImperial_API.Models.BankAccounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BahiaImperial_API.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> user)
        {
            user.ToTable("users");

            user.HasKey(u => u.Cpf_Cnpj);

            user.Property(u => u.Cpf_Cnpj)
                .HasMaxLength(14)
                .IsRequired();

            user.Property(u => u.Password)
                .HasMaxLength(20)
                .IsRequired();

            user.HasOne(u => u.Client)
                .WithOne(c => c.User)
                .HasForeignKey<Client>(c => c.Cpf_Cnpj)
                .OnDelete(DeleteBehavior.Cascade);

            user.HasMany(u => u.Accounts)
                .WithOne()
                .HasForeignKey(a => a.Cpf_Cnpj)
                .IsRequired();
        }
    }
}