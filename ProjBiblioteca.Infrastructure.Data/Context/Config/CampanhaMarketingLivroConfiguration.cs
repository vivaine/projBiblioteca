using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjBiblioteca.Domain.Entities;

namespace ProjBiblioteca.Infrastructure.Data.Context.Config
{
    public class CampanhaMarketingLivroConfiguration : IEntityTypeConfiguration<CampanhaMarketingLivro>
    {
        public void Configure(EntityTypeBuilder<CampanhaMarketingLivro> builder)
        {
            builder.HasKey(cl => new { cl.MarketingID, cl.LivroID});

            builder.HasOne(cl => cl.Livro)
                .WithMany(l => l.LivCampanha)
                .HasForeignKey(cl => cl.LivroID);

            builder.HasOne(cl => cl.CampanhaMarketing)
                .WithMany(c => c.LivCampanha)
                .HasForeignKey(cl => cl.MarketingID);
        }
    }
}