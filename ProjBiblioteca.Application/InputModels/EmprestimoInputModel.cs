using System.Collections.Generic;

namespace ProjBiblioteca.Application.InputModels
{
    public class EmprestimoInputModel
    {
        public int Id { get; set; }

        public string UsuarioID { get; set; }

        public string SessionUserID { get; set; }
    }
}