using System.Collections.Generic;

namespace ProjBiblioteca.Application.ViewModels
{
    public class LivroListViewModel
    {
        public IEnumerable<LivroViewModel> Livros {get; set; }
    }
}