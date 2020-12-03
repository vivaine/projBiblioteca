using System.Collections.Generic;
using ProjBiblioteca.Application.InputModels;
using ProjBiblioteca.Application.ViewModels;

namespace ProjBiblioteca.Application.Interfaces
{
    public interface ICarrinhoService
    {
        CarrinhoListViewModel GetPorSession(string sessionId);

        CarrinhoViewModel Post(CarrinhoInputModel autor);

        CarrinhoViewModel Delete(int id);
    }
}