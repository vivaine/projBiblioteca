using AutoMapper;
using ProjBiblioteca.Domain.Entities;

namespace ProjBiblioteca.Application.ViewModels.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Autor, AutorViewModel>()
                .ForMember(a => a.Id,
                            opt => opt.MapFrom(src => src.AutorID))
                .ReverseMap();

            CreateMap<Livro, LivroViewModel>()
                .ForMember(dest => dest.Id, 
                        opt => opt.MapFrom(src => src.LivroID))
                .ForMember(dest => dest.Autores,
                            opt => opt.MapFrom(src => src.LivAutor))                          
                .ReverseMap();

            CreateMap<Carrinho, CarrinhoViewModel>()
                .ForMember(dest => dest.Id, 
                           opt => opt.MapFrom(src => src.CarrinhoID))
                .ForMember(dest => dest.NomeLivro,
                           opt => 
                            {
                                opt.PreCondition(src => src.Livro != null);
                                opt.MapFrom(src => src.Livro.Titulo);
                            })
                .ReverseMap();

            CreateMap<Usuario, UsuarioViewModel>()
                .ForMember(dest => dest.Id, 
                           opt => opt.MapFrom(src => src.UsuarioID))
                .ReverseMap();

            CreateMap<Emprestimo, EmprestimoViewModel>()
                .ForMember(dest => dest.Id, 
                           opt => opt.MapFrom(src => src.EmprestimoID))
                // .ForMember(dest => dest.Livros,
                //             opt => opt.MapFrom(src => src.LivEmprestimo))   
                .ReverseMap();

            CreateMap<Genero, GeneroViewModel>()
                .ForMember(dest => dest.Id,
                            opt => opt.MapFrom(src => src.GeneroID))
                .ReverseMap();

            CreateMap<CampanhaMarketing, CampanhaMarketingViewModel>()
                .ForMember(dest => dest.Id,
                            opt => opt.MapFrom(src => src.MarketingID))
                .ReverseMap();

        }
    }
}