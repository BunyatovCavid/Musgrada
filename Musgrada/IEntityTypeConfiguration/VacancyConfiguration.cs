using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class VacancyConfiguration : IEntityTypeConfiguration<Vacancy>
    {
        public void Configure(EntityTypeBuilder<Vacancy> b)
        {
            b.HasIndex(v => v.Name).IsUnique();
            b.Property(v => v.Name).IsRequired().HasMaxLength(20);
            b.Property(v => v.Description).IsRequired();
            b.Property(v => v.CityId).HasMaxLength(4);
            b.Property(v => v.VacancyCategoryId).HasMaxLength(2);
            b.HasMany(v => v.SendVacancyCVs)
                .WithOne(svc => svc.Vacancy)
                .HasForeignKey(svc => svc.VacancyId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
