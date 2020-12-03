using System.Collections.Generic;
using ProjBiblioteca.Domain.Entities;

namespace ProjBiblioteca.Domain.Interfaces
{
    public interface IEmprestimoRepository  : IRepository<Emprestimo>
    {
        IEnumerable<Emprestimo> GetEmprestimoPorUsuario(int usuarioId);

        Emprestimo GetEmprestimoInclude(int emprestimoId);
    }
}