using ProjBiblioteca.Domain.Interfaces;
using ProjBiblioteca.Application.ViewModels;
using ProjBiblioteca.Application.Interfaces;
using System.Collections.Generic;
using ProjBiblioteca.Application.InputModels;
using ProjBiblioteca.Domain.Entities;
using AutoMapper;

namespace ProjBiblioteca.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        public IUnitOfWork _uow;

        public IMapper _mapper;

        public UsuarioService(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }

        public UsuarioListViewModel Get()
        {
            var usuarios = this._uow.UsuarioRepository.Get();

            return new UsuarioListViewModel()
            {
                Usuarios = _mapper.Map<IEnumerable<UsuarioViewModel>>(usuarios)
            };
        }
        public UsuarioViewModel Post(UsuarioInputModel usuarioInputModel)
        {
            var usuario = _mapper.Map<Usuario>(usuarioInputModel);

            _uow.UsuarioRepository.Add(usuario);
            _uow.Commit();

            return _mapper.Map<UsuarioViewModel>(usuario);
        }        
        
    }
}