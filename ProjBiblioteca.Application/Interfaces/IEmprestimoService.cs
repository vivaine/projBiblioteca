using ProjBiblioteca.Application.InputModels;
using ProjBiblioteca.Application.ViewModels;

namespace ProjBiblioteca.Application.Interfaces
{
    public interface IEmprestimoService
    {
        EmprestimoListViewModel GetPorUsuario(int usuarioId);

        EmprestimoViewModel GetEmprestimoDetalhes(int emprestimoId);

        EmprestimoViewModel CriarEmprestimo(EmprestimoInputModel emprestimo);

        EmprestimoViewModel DevolverLivros(int emprestimoId);
    }
}