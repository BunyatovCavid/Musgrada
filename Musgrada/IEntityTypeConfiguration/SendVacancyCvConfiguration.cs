using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class SendVacancyCvConfiguration : IEntityTypeConfiguration<SendVacancyCV>
    {
        public void Configure(EntityTypeBuilder<SendVacancyCV> b)
        {
            b.HasIndex(svc => svc.Name).IsUnique();
            b.Property(svc => svc.Name).IsRequired().HasMaxLength(30);
            b.Property(svc => svc.Phone).IsRequired().HasMaxLength(20);
            b.Property(svc => svc.Email).IsRequired().HasMaxLength(30);
            b.Property(svc => svc.Birthday).HasMaxLength(30);
            b.Property(svc => svc.ResidentalAdress).HasMaxLength(200);
            b.Property(svc => svc.GenderId).HasMaxLength(1);
            b.Property(svc => svc.VacancyId).HasMaxLength(5);
            b.Property(svc => svc.SubName).HasMaxLength(20);
        }
    }
}
