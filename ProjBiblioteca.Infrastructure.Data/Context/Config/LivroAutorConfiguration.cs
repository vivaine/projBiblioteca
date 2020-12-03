using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjBiblioteca.Domain.Entities;

namespace ProjBiblioteca.Infrastructure.Data.Context.Config
{
    public class LivroAutorConfiguration : IEntityTypeConfiguration<LivroAutor>
    {
        public void Configure(EntityTypeBuilder<LivroAutor> builder)
        {
            #region LivroAutor

            builder.HasKey(bc => new { bc.AutorID, bc.LivroID});

            builder.HasOne(bc => bc.Autor)
                .WithMany(b => b.LivAutor)
                .HasForeignKey(bc => bc.AutorID);

            builder.HasOne(bc => bc.Livro)
                .WithMany(b => b.LivAutor)
                .HasForeignKey(bc => bc.LivroID);

            #endregion
        }
    }
}