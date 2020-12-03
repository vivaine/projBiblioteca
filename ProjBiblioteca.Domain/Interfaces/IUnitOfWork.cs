namespace ProjBiblioteca.Domain.Interfaces
{
    public interface IUnitOfWork
    {
         IAutorRepository AutorRepository { get; }

         ILivroRepository LivroRepository { get; }

        ICarrinhoRepository CarrinhoRepository { get; }

        IUsuarioRepository UsuarioRepository { get; }

        IEmprestimoRepository EmprestimoRepository { get; }

        IGeneroRepository GeneroRepository { get; }

        ICampanhaMarketingRepository CampanhaMarketingRepository { get; }

         void Commit();
    }
}