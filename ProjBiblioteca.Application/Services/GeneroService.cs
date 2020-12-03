using System.Collections.Generic;
using AutoMapper;
using ProjBiblioteca.Application.InputModels;
using ProjBiblioteca.Application.Interfaces;
using ProjBiblioteca.Application.ViewModels;
using ProjBiblioteca.Domain.Entities;
using ProjBiblioteca.Domain.Interfaces;

namespace ProjBiblioteca.Application.Services
{
    public class GeneroService : IGeneroService
    {

        private IUnitOfWork _uow;   
        private IMapper _mapper;

        public GeneroService(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }

        public GeneroViewModel Delete(int id)
        {
            var genero = this._uow.GeneroRepository.GetById(g => g.GeneroID == id);

            if (genero == null)
            {
                return null;
            }

            _uow.GeneroRepository.Delete(genero);
            _uow.Commit();

            return _mapper.Map<GeneroViewModel>(genero);
        }

        public GeneroListViewModel Get()
        {
            var generos = _uow.GeneroRepository.Get();

            return new GeneroListViewModel() {
                Generos = _mapper.Map<IEnumerable<GeneroViewModel>>(generos)
            };
        }

        public GeneroViewModel Get(int id)
        {
            var genero = _uow.GeneroRepository.GetById(g => g.GeneroID == id);
            
            return _mapper.Map<GeneroViewModel>(genero);
        }

        public GeneroViewModel Post(GeneroInputModel generoInputModel)
        {
            var genero = _mapper.Map<Genero>(generoInputModel);

            _uow.GeneroRepository.Add(genero);
            _uow.Commit();

            return _mapper.Map<GeneroViewModel>(genero);
        }

        public GeneroViewModel Put(int id, GeneroInputModel generoInputModel)
        {
            var genero = _mapper.Map<Genero>(generoInputModel);

            _uow.GeneroRepository.Update(genero);
            _uow.Commit();

            return _mapper.Map<GeneroViewModel>(genero);
        }
    }
}