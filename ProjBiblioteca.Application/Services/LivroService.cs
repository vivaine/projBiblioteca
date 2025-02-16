using ProjBiblioteca.Domain.Interfaces;
using ProjBiblioteca.Application.ViewModels;
using ProjBiblioteca.Application.Interfaces;
using ProjBiblioteca.Application.InputModels;
using AutoMapper;
using ProjBiblioteca.Domain.Entities;
using System.Collections.Generic;

namespace ProjBiblioteca.Application.Services
{
    public class LivroService : ILivroService
    {
        private IUnitOfWork _uow;

        private IMapper _mapper;

        public LivroService(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }

        public LivroViewModel Delete(int id)
        {
            var livro = this._uow.LivroRepository.GetById(l => l.LivroID == id);

            if (livro == null)
            {
                return null;
            }

            _uow.LivroRepository.Delete(livro);
            _uow.Commit();

            return _mapper.Map<LivroViewModel>(livro);
        }

        public LivroListViewModel Get()
        {
            var livros = this._uow.LivroRepository.Get();

            return new LivroListViewModel() {
                Livros = _mapper.Map<IEnumerable<LivroViewModel>>(livros)
            };
        }

        public LivroViewModel Get(int id)
        {
            var livro = this._uow.LivroRepository.GetById(l => l.LivroID == id);

            return _mapper.Map<LivroViewModel>(livro);
        }

        public LivroViewModel Post(LivroInputModel livroInputModel)
        {
            var livro = _mapper.Map<Livro>(livroInputModel);

            _uow.LivroRepository.Add(livro);
            _uow.Commit();

            return _mapper.Map<LivroViewModel>(livro);
        }

        public LivroViewModel Put(int id, LivroInputModel livroInputModel)
        {
            var livro = _mapper.Map<Livro>(livroInputModel);

            _uow.LivroRepository.Update(livro);
            _uow.Commit();

            return _mapper.Map<LivroViewModel>(livro);
        }
    }
}