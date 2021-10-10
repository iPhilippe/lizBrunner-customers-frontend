using LizBrunner.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace LizBrunner.Data.Mappings
{
    public class ClientMapping : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.Property(c => c.Birthdate)
                .IsRequired();
            
            builder.Property(c => c.Gender)
                .IsRequired();
            
            builder.Property(c => c.CPF)
                .IsRequired()
                .HasColumnType("varchar(11)");

            builder.Property(c => c.Phone)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(c => c.Email)
                .IsRequired();
            
            builder.Property(c => c.RegisterDate)
                .IsRequired();

            builder.Property(a => a.Street)
               .IsRequired()
               .HasColumnType("varchar(100)");

            builder.Property(a => a.Number)
                .IsRequired();

            builder.Property(a => a.Complement)
                .HasColumnType("varchar(70)");

            builder.Property(a => a.Zipcode)
                .IsRequired();

            builder.Property(a => a.Neighborhood)
                .IsRequired()
                .HasColumnType("varchar(70)");

            builder.Property(a => a.City)
                .IsRequired();

            builder.Property(a => a.State)
                .IsRequired();

            builder.ToTable("Clients");
        }
    }


}
