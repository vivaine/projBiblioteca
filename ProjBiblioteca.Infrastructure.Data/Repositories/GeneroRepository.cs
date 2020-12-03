using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ProjBiblioteca.Domain.Entities;
using ProjBiblioteca.Domain.Interfaces;
using ProjBiblioteca.Infrastructure.Data.Context;

namespace ProjBiblioteca.Infrastructure.Data.Repositories
{
    public class GeneroRepository : Repository<Genero>, IGeneroRepository
    {
      
        public GeneroRepository(BibliotecaDbContext context) : base(context)
        {

        }

    }
}