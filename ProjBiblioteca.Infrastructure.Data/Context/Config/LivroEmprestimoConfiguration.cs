using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjBiblioteca.Domain.Entities;

namespace ProjBiblioteca.Infrastructure.Data.Context.Config
{
    public class LivroEmprestimoConfiguration : IEntityTypeConfiguration<LivroEmprestimo>
    {
        public void Configure(EntityTypeBuilder<LivroEmprestimo> builder)
        {
            #region LivroEmprestimo

            builder.HasKey(bc => new { bc.LivroID, bc.EmprestimoID});

            builder.HasOne(bc => bc.Livro)
                .WithMany(b => b.LivEmprestimo)
                .HasForeignKey(bc => bc.LivroID);
            
            builder.HasOne(bc => bc.Emprestimo)
                .WithMany(b => b.LivEmprestimo)
                .HasForeignKey(bc => bc.EmprestimoID);

            #endregion
        }
    }
}