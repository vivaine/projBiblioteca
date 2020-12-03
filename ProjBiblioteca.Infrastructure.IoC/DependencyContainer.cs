using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjBiblioteca.Application.Interfaces;
using ProjBiblioteca.Application.Services;
using ProjBiblioteca.Domain.Interfaces;
using ProjBiblioteca.Infrastructure.Data.Context;
using ProjBiblioteca.Infrastructure.Data.Repositories;

namespace ProjBiblioteca.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IAutorService, AutorService>();
            services.AddScoped<ILivroService, LivroService>();
            services.AddScoped<ICarrinhoService, CarrinhoService>();
            services.AddScoped<IEmprestimoService, EmprestimoService>();
            services.AddScoped<IGeneroService, GeneroService>();
            services.AddScoped<ICampanhaMarketingService, CampanhaMarketingService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
        
        public static void RegisterContexts(IServiceCollection services, string conn)
        {
            services.AddDbContext<BibliotecaDbContext>(options => options.UseNpgsql(conn));
        }

        public static void RegisterMappers(IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new Application.ViewModels.Mapping.MappingProfile());
                mc.AddProfile(new Application.InputModels.Mapping.MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }

    }
}