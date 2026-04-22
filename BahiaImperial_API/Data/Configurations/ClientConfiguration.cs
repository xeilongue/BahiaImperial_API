using BahiaImperial_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BahiaImperial_API.Data.Configurations
{
    public class ClientConfiguration
    {
        public void Configure(EntityTypeBuilder<Client> client)
        {
            client.ToTable("clients");

            client.Property(c => c.Cpf_Cnpj)
                .HasMaxLength(14)
                .IsRequired();

            client.Property(c => c.Name)
                .HasMaxLength(255)
                .IsRequired();

            client.Property(c => c.MonthlyIncome)
                .HasPrecision(15, 2)
                .IsRequired();

        }
    }
}
