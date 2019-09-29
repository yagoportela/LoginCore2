using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities;

namespace Project.Infra.Data.Mapping
{
    public class WorkshopMap : IEntityTypeConfiguration<WorkshopEntity>
    {
        public void Configure(EntityTypeBuilder<WorkshopEntity> builder)
        {
            builder.ToTable("Workshop");

            builder.HasKey(u => u.Id); 

            builder.HasOne(a => a.User);       

            builder.HasOne(a => a.Company);

            builder.HasOne(a => a.Address);

            builder.Property(a => a.NameWorkshop)
                   .HasMaxLength(200);

            builder.Property(a => a.Phone1)
                   .HasMaxLength(15);
            
            builder.Property(a => a.Phone2)
                   .HasMaxLength(15);                  
                   
        }
    }
}