using LizBrunner.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LizBrunner.Data.Mappings
{
    public class AdressMapping : IEntityTypeConfiguration<Adress>
    {
        public void Configure(EntityTypeBuilder<Adress> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Street)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(a => a.Number)
                .IsRequired();

            builder.Property(a => a.Complement)
                .IsRequired();

            builder.Property(a => a.Neighborhood)
                .IsRequired()
                .HasColumnType("varchar(70)");

            builder.Property(a => a.City)
                .IsRequired();

            builder.Property(a => a.State)
                .IsRequired();



            builder.ToTable("Adresses");
        }
    }
}
