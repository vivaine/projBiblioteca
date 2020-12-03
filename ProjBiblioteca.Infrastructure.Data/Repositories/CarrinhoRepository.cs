using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjBiblioteca.Domain.Entities;
using ProjBiblioteca.Domain.Interfaces;
using ProjBiblioteca.Infrastructure.Data.Context;

namespace ProjBiblioteca.Infrastructure.Data.Repositories {
    public class CarrinhoRepository : Repository<Carrinho>, ICarrinhoRepository {
        public CarrinhoRepository (BibliotecaDbContext context) : base (context) { }

        public IEnumerable<Carrinho> GetCarrinhoPorSessionId (string idSession) {
            return _context.Carrinho.AsNoTracking ()
                .Include (c => c.Livro)
                .Where (c => c.SessionUserID == idSession);
        }
    }
}