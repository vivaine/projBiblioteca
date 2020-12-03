using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjBiblioteca.Domain.Entities;

namespace ProjBiblioteca.Infrastructure.Data.Context.Config
{
    public class LivroConfiguration : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.Property(t => t.Titulo)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(t => t.Foto)
                .HasMaxLength(300);

            builder.Property(t => t.Editora)
                .HasMaxLength(100);
        }
    }
}