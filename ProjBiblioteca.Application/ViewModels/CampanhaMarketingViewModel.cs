using System;

namespace ProjBiblioteca.Application.ViewModels
{
    public class CampanhaMarketingViewModel
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }
        
        public Double PercentualDesconto { get; set; }
        
    }
}