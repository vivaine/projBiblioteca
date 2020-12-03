using System.Collections.Generic;
using ProjBiblioteca.Application.DTOs;

namespace ProjBiblioteca.Application.ViewModels
{
    public class LivroViewModel
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public int? Quantidade { get; set; }

        public string Foto { get; set; }

        public int? Ano { get; set; }

        public int? Edicao { get; set; }

        public int? Paginas { get; private set; }

        public string Editora { get; set; }
        
        public IList<AutorSelectListDto> Autores { get; set; }
    }
}