using ProjBiblioteca.Application.InputModels;
using ProjBiblioteca.Application.ViewModels;

namespace ProjBiblioteca.Application.Interfaces
{
    public interface ILivroService
    {
        LivroListViewModel Get();     
        LivroViewModel Get(int id);
        LivroViewModel Post(LivroInputModel livroInputModel);
        LivroViewModel Put(int id, LivroInputModel livroInputModel);
        LivroViewModel Delete(int id);
        
    }
}