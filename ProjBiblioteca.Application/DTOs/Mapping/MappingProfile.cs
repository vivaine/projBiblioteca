using AutoMapper;
using ProjBiblioteca.Domain.Entities;

namespace ProjBiblioteca.Application.DTOs.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LivroAutor, AutorSelectListDto>()
                .ForMember(dest => dest.AutorID, 
                            opt => opt.MapFrom(src => src.AutorID))
                .ReverseMap();
        }        
    }
}