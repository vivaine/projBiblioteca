using ProjBiblioteca.Domain.Entities;
using ProjBiblioteca.Domain.Interfaces;
using ProjBiblioteca.Infrastructure.Data.Context;

namespace ProjBiblioteca.Infrastructure.Data.Repositories
{
    public class CampanhaMarketingRepository : Repository<CampanhaMarketing>, ICampanhaMarketingRepository
    {
        public CampanhaMarketingRepository(BibliotecaDbContext context) : base(context)
        {
            
        }
        
    }
}