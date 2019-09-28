using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities;

namespace Project.Infra.Data.Mapping
{
    public class AddressMap : IEntityTypeConfiguration<AddressEntity>
    {
        public void Configure(EntityTypeBuilder<AddressEntity> builder)
        {
           builder.ToTable("Address");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Countries);    

            builder.Property(a => a.State);   

            builder.Property(a => a.City)
                   .HasMaxLength(200);

            builder.Property(a => a.District)
                   .HasMaxLength(200);

            builder.Property(a => a.Street)
                   .HasMaxLength(200);

            builder.Property(a => a.Number)
                   .HasMaxLength(20);

            builder.Property(a => a.Complement)
                   .HasMaxLength(200);

            builder.Property(a => a.ZipCode)
                   .HasMaxLength(20);

            builder.Property(a => a.Longitude)
                   .HasMaxLength(100);

            builder.Property(a => a.Altitude)
                   .HasMaxLength(100);

            builder.Property(a => a.State)
                   .HasMaxLength(200);

            builder.Property(a => a.Obs)
                   .HasMaxLength(200);
            
        }
    }
}