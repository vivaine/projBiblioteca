using System.Collections.Generic;

namespace ProjBiblioteca.Application.ViewModels
{
    public class EmprestimoListViewModel
    {
        public IEnumerable<EmprestimoViewModel> Emprestimos { get; set; }
    }
}