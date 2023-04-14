using Chapter.Contexts;
using Chapter.Model;
namespace Chapter.Repositories
{
    public class LivroRepositury
    {
        private readonly ChapterContext _context;
        public LivroRepositury(ChapterContext context)
        {
            _context = context; 
        }
        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }
    }
}
