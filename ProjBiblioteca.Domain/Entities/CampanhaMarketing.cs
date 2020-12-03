using System;
using System.Collections.Generic;

namespace ProjBiblioteca.Domain.Entities
{
    public class CampanhaMarketing
    {
        public int MarketingID { get; set; }
        
        public string Descricao { get; set; }
        
        public DateTime DataInicio { get; set; }
        
        public DateTime DataFim { get; set; }
        
        public Double PercentualDesconto { get; set; }       

        public ICollection<CampanhaMarketingLivro> LivCampanha { get; set; } 
        
    }
}