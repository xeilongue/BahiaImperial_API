using BahiaImperial_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BahiaImperial_API.Data.Configurations
{
    public class UserConfiguration
    {
        public void Configure(EntityTypeBuilder<User> user)
        {
            user.ToTable("users");

            user.Property(u => u.Cpf_Cnpj)
                .HasMaxLength(14)
                .IsRequired();

            user.Property(u => u.Password)
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}