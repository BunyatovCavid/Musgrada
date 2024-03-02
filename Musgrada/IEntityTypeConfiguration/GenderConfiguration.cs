using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;


namespace Musgrada.IEntityTypeConfiguration
{
    public class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> b)
        {
            b.HasIndex(g => g.Name).IsUnique();
            b.Property(g => g.Name).IsRequired().HasMaxLength(10);

            b.HasMany(g => g.SendVacancyCVs)
                .WithOne(svc => svc.Gender)
                .HasForeignKey(svc => svc.GenderId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
