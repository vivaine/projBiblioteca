using ProjBiblioteca.Domain.Entities;
using System.Collections.Generic;

namespace ProjBiblioteca.Application.ViewModels
{
    public class UsuarioListViewModel
    {
        public IEnumerable<UsuarioViewModel> Usuarios { get; set; }
        
        
    }
}