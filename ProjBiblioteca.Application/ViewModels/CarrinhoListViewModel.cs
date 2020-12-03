using System.Collections.Generic;

namespace ProjBiblioteca.Application.ViewModels
{
    public class CarrinhoListViewModel
    {
        public IEnumerable<CarrinhoViewModel> Items { get; set; }
    }
}