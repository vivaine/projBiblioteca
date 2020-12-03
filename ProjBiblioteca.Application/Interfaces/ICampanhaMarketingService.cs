using ProjBiblioteca.Application.InputModels;
using ProjBiblioteca.Application.ViewModels;

namespace ProjBiblioteca.Application.Interfaces
{
    public interface ICampanhaMarketingService
    {
         CampanhaMarketingListViewModel Get();

         CampanhaMarketingViewModel Get(int id);

         CampanhaMarketingViewModel Post(CampanhaMarketingInputModel campanhaMarketingInputModel);

         CampanhaMarketingViewModel Put(int id, CampanhaMarketingInputModel campanhaMarketingInputModel);

         CampanhaMarketingViewModel Delete(int id);
    }
}