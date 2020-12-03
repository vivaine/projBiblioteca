using System.Collections.Generic;

namespace ProjBiblioteca.Domain.Entities
{
    public class Livro
    {
        public int LivroID { get; set; }    

        public string Titulo { get; set; }  

        public int? Quantidade { get; set; } 

        public string Foto { get; set; }

        public int? GeneroID { get; set; }

        public int? Ano { get; set; }

        public int? Edicao { get; set; }

        public int? Paginas { get; set; }

        public string Editora { get; set; }
        
        public virtual Genero Genero { get; set; }   

        public ICollection<LivroAutor> LivAutor { get; set; }

        public ICollection<LivroEmprestimo> LivEmprestimo { get; set; }

        public ICollection<CampanhaMarketingLivro> LivCampanha { get; set; }
        
    }
}