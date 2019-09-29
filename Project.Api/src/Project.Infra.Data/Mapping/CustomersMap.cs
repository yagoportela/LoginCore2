using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities;

namespace Project.Infra.Data.Mapping
{
    public class CustomersMap : IEntityTypeConfiguration<CustomersEntity>
    {
        public void Configure(EntityTypeBuilder<CustomersEntity> builder)
        {
            builder.ToTable("Customers");

            builder.HasKey(a => a.Id);

            builder.HasOne(a => a.User);
            
            builder.HasOne(a => a.Address);              
            
            builder.Property(a => a.CPF)
                   .HasMaxLength(30)
                   .IsRequired();

            builder.Property(a => a.RG)
                   .HasMaxLength(30);

            builder.Property(a => a.BirthDate);

        }
    }
}