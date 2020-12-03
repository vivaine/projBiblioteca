
using ProjBiblioteca.Domain.Interfaces;
using ProjBiblioteca.Application.ViewModels;
using ProjBiblioteca.Application.Interfaces;
using AutoMapper;
using ProjBiblioteca.Application.InputModels;
using ProjBiblioteca.Domain.Entities;
using System.Collections.Generic;

namespace ProjBiblioteca.Application.Services
{
    public class AutorService : IAutorService
    {
        private IUnitOfWork _uow;   
        private IMapper _mapper;

        public AutorService(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }

        public AutorViewModel Delete(int id)
        {
            var autor = this._uow.AutorRepository.GetById(a => a.AutorID == id);
            
            if (autor == null)
            {
                return null;
            }

            _uow.AutorRepository.Delete(autor);
            _uow.Commit();

            return _mapper.Map<AutorViewModel>(autor);
        }

        public AutorListViewModel Get()
        {
            var autores = this._uow.AutorRepository.Get();

            return new AutorListViewModel() {
                Autores = _mapper.Map<IEnumerable<AutorViewModel>>(autores)
            };
        }

        public AutorViewModel Get(int id)
        {
            var autor = this._uow.AutorRepository.GetById(a => a.AutorID == id);

            return _mapper.Map<AutorViewModel>(autor);
        }

        public AutorViewModel Post(AutorInputModel autorInputModel)
        {
            var autor = _mapper.Map<Autor>(autorInputModel);

            _uow.AutorRepository.Add(autor);
            _uow.Commit();

            return _mapper.Map<AutorViewModel>(autor);
        }

        public AutorViewModel Put(int id, AutorInputModel autorInputModel)
        {
            var autor = _mapper.Map<Autor>(autorInputModel);

            _uow.AutorRepository.Update(autor);
            _uow.Commit();

            return _mapper.Map<AutorViewModel>(autor);
        }
    }
}