using Microsoft.EntityFrameworkCore;
using Chapter.Model;
namespace Chapter.Contexts

{
    public class ChapterContext : DbContext
    {
        public ChapterContext()
        {

        }

        public ChapterContext(DbContextOptions<ChapterContext> options) : base (options)
        {

        }

        // utilizar metodo para configurar banco de dados

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-UH7VRS2\\SQLEXPRESS; initial catalog = Chapter; Integrate Security = true");
            }
        }

        public DbSet<Livro> Livros { get; set; }
    }
}
