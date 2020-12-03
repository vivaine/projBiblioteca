using ProjBiblioteca.Domain.Interfaces;
using ProjBiblioteca.Infrastructure.Data.Context;

namespace ProjBiblioteca.Infrastructure.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private AutorRepository _autorRepo;

        private LivroRepository _livroRepo;
        private CarrinhoRepository _carrinhoRepo;

        private UsuarioRepository _usuarioRepo;

        private EmprestimoRepository _emprestimoRepo;        

        private GeneroRepository _generoRepo;

        private CampanhaMarketingRepository _campanhaMarketingRepo;

        private BibliotecaDbContext _context;

        public UnitOfWork(BibliotecaDbContext context)
        {
            _context = context;
        }

        public IAutorRepository AutorRepository
        {
            get {
                return _autorRepo = _autorRepo ??
                            new AutorRepository(_context);
            }
        }

        public ILivroRepository LivroRepository
        {
            get {
                return _livroRepo = _livroRepo ??
                        new LivroRepository(_context);
            }
        }

       public ICarrinhoRepository CarrinhoRepository
        {
            get { 
                return _carrinhoRepo = _carrinhoRepo ?? new CarrinhoRepository(_context);
            }
        }

        public IUsuarioRepository UsuarioRepository
        {
            get { 
                return _usuarioRepo = _usuarioRepo ?? new UsuarioRepository(_context);
            }
        }

        public IEmprestimoRepository EmprestimoRepository
        {
            get { 
                return _emprestimoRepo = _emprestimoRepo ?? new EmprestimoRepository(_context);
            }
        }

        public IGeneroRepository GeneroRepository
        {
            get {
                return _generoRepo = _generoRepo ?? new GeneroRepository(_context);
            }
        }

        public ICampanhaMarketingRepository CampanhaMarketingRepository
        {
            get {
                return _campanhaMarketingRepo = _campanhaMarketingRepo
                    ?? new CampanhaMarketingRepository(_context);
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}