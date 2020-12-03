using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ProjBiblioteca.Domain.Entities;
using ProjBiblioteca.Infrastructure.Data.Context.Config;

namespace ProjBiblioteca.Infrastructure.Data.Context
{
    public class BibliotecaDbContext : DbContext
    {
        public BibliotecaDbContext(DbContextOptions<BibliotecaDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Autor> Autor { get; set; }

        public DbSet<Livro> Livro { get; set; }  

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Emprestimo> Emprestimo { get; set; }

        public DbSet<LivroAutor> LivroAutor { get; set; }

        public DbSet<LivroEmprestimo> LivroEmprestimo { get; set; }

        public DbSet<Genero> Genero { get; set; }

        public DbSet<CampanhaMarketing> CampanhaMarketing { get; set; }

        public DbSet<CampanhaMarketingLivro> CampanhaMarketingLivro { get; set; }

        public DbSet<Carrinho> Carrinho { get; set; }
    }
}