namespace ProjBiblioteca.Domain.Entities
{
    public class CampanhaMarketingLivro
    {
        public int MarketingID { get; set; }

        public CampanhaMarketing CampanhaMarketing { get; set; }
       
        public int LivroID { get; set; }

        public Livro Livro { get; set; }       
    }
}