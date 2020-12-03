using System.Collections.Generic;
using AutoMapper;
using ProjBiblioteca.Application.InputModels;
using ProjBiblioteca.Application.Interfaces;
using ProjBiblioteca.Application.ViewModels;
using ProjBiblioteca.Domain.Entities;
using ProjBiblioteca.Domain.Interfaces;

namespace ProjBiblioteca.Application.Services
{
    public class CampanhaMarketingService : ICampanhaMarketingService
    {
        private IUnitOfWork _uow;   
        private IMapper _mapper;

        public CampanhaMarketingService(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }

        public CampanhaMarketingViewModel Delete(int id)
        {
            var campanha = this._uow.CampanhaMarketingRepository.GetById(c => c.MarketingID == id);
            
            if (campanha == null)
            {
                return null;
            }

            _uow.CampanhaMarketingRepository.Delete(campanha);
            _uow.Commit();

            return _mapper.Map<CampanhaMarketingViewModel>(campanha);
        }

        public CampanhaMarketingListViewModel Get()
        {
            var campanhas = this._uow.CampanhaMarketingRepository.Get();

            return new CampanhaMarketingListViewModel() {
                Campanhas = _mapper.Map<IEnumerable<CampanhaMarketingViewModel>>(campanhas)
            };
        }

        public CampanhaMarketingViewModel Get(int id)
        {
            var campanha = this._uow.CampanhaMarketingRepository.GetById(c => c.MarketingID == id);

            return _mapper.Map<CampanhaMarketingViewModel>(campanha);
        }

        public CampanhaMarketingViewModel Post(CampanhaMarketingInputModel campanhaMarketingInputModel)
        {
            var campanha = _mapper.Map<CampanhaMarketing>(campanhaMarketingInputModel);

            _uow.CampanhaMarketingRepository.Add(campanha);
            _uow.Commit();

            return _mapper.Map<CampanhaMarketingViewModel>(campanha);
        }

        public CampanhaMarketingViewModel Put(int id, CampanhaMarketingInputModel campanhaMarketingInputModel)
        {
            var campanha = _mapper.Map<CampanhaMarketing>(campanhaMarketingInputModel);

            // var campanha2 = _uow.CampanhaMarketingRepository.GetById(c => c.MarketingID == id);

            // if (campanha2 == null)
            // {
            //     return null;
            // }

            _uow.CampanhaMarketingRepository.Update(campanha);
            _uow.Commit();

            return _mapper.Map<CampanhaMarketingViewModel>(campanha);
        }
    }
}