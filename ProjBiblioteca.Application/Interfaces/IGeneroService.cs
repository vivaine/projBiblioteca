using ProjBiblioteca.Application.InputModels;
using ProjBiblioteca.Application.ViewModels;

namespace ProjBiblioteca.Application.Interfaces
{
    public interface IGeneroService
    {
        GeneroListViewModel Get();

        GeneroViewModel Get(int id);

        GeneroViewModel Post(GeneroInputModel generoInputModel);
        
        GeneroViewModel Put(int id, GeneroInputModel generoInputModel);

        GeneroViewModel Delete(int id);
         
    }
}