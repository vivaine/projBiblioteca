using ProjBiblioteca.Application.InputModels;
using ProjBiblioteca.Application.ViewModels;

namespace ProjBiblioteca.Application.Interfaces
{
    public interface IAutorService
    {
         AutorListViewModel Get();

         AutorViewModel Get(int id);

         AutorViewModel Post(AutorInputModel autorInputModel);

         AutorViewModel Put(int id, AutorInputModel autorInputModel);

         AutorViewModel Delete(int id);
    }
}