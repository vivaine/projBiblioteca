using System.Collections.Generic;
using ProjBiblioteca.Domain.Entities;

namespace ProjBiblioteca.Domain.Interfaces
{
    public interface ICarrinhoRepository  : IRepository<Carrinho>
    {
         IEnumerable<Carrinho> GetCarrinhoPorSessionId(string idSession);
    }
}