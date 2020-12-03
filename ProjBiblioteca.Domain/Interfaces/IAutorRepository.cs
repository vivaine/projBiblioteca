using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ProjBiblioteca.Domain.Entities;

namespace ProjBiblioteca.Domain.Interfaces
{
    public interface IAutorRepository : IRepository<Autor>
    {
        IEnumerable<Autor> GetAutoresContemNome(string nome);
        
    }
}