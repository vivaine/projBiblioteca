using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjBiblioteca.Domain.Entities;

namespace ProjBiblioteca.Infrastructure.Data.Context.Config
{
    public class CampanhaMarketingConfiguration : IEntityTypeConfiguration<CampanhaMarketing>
    {
        public void Configure(EntityTypeBuilder<CampanhaMarketing> builder)
        {
            builder.HasKey(c => c.MarketingID);

            builder.Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}