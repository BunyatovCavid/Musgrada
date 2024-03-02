using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class VacancyCategoryConfiguration : IEntityTypeConfiguration<VacancyCategory>
    {
        public void Configure(EntityTypeBuilder<VacancyCategory> b)
        {
             b.HasIndex(vc => vc.Name).IsUnique();
            b.Property(vc => vc.Name).IsRequired().HasMaxLength(30);
            b.HasMany(vc => vc.Vacancies)
                .WithOne(v => v.VacancyCategory)
                .HasForeignKey(v => v.VacancyCategoryId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
