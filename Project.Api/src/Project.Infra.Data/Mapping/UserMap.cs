using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities;

namespace Project.Infra.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Tipo)
                .IsRequired()
                .HasColumnName("Name");

            builder.Property(c => c.ImgPerfil)
                .IsRequired()
                .HasColumnName("Email");

            builder.Property(c => c.ImgPerfil)
                .IsRequired()
                .HasColumnName("Cell");
        }
    }
}
