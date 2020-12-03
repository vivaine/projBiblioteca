using System.Collections.Generic;
using System.Linq;
using ProjBiblioteca.Domain.Entities;
using ProjBiblioteca.Domain.Interfaces;
using ProjBiblioteca.Infrastructure.Data.Context;

namespace ProjBiblioteca.Infrastructure.Data.Repositories
{
    public class AutorRepository : Repository<Autor>, IAutorRepository
    {
        public AutorRepository(BibliotecaDbContext context) : base(context)
        {
            
        }

        public IEnumerable<Autor> GetAutoresContemNome(string nome)
        {
            return _context.Autor.Where(a => a.Nome.Contains(nome));
        }
    }
}