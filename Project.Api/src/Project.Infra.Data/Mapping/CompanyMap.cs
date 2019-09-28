using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities;

namespace Project.Infra.Data.Mapping
{
    public class CompanyMap : IEntityTypeConfiguration<CompanyEntity>
    {
        public void Configure(EntityTypeBuilder<CompanyEntity> builder)
        {
              builder.ToTable("User");

              builder.HasKey(u => u.Id);

              builder.Property(a => a.UserEntity)
                   .IsRequired();
                   
              builder.Property(a => a.AddressEntity)
                   .IsRequired();                     
            
              builder.Property(a => a.CNPJ)
                     .HasMaxLength(30);

              builder.Property(a => a.RazaoSocial)
                     .HasMaxLength(200);
              
              builder.Property(a => a.NomeFantasia)
                     .HasMaxLength(200);
              
              builder.Property(a => a.Phone1)
                     .HasMaxLength(15);
              
              builder.Property(a => a.Phone2)
                     .HasMaxLength(15);    
        }
    }
}