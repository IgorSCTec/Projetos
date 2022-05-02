using Microsoft.EntityFrameworkCore;

namespace GerenciadoDeTarefas.Models
{
    public class GerenciadoDeTarefasContext : DbContext
    {
        public GerenciadoDeTarefasContext(DbContextOptions<GerenciadoDeTarefasContext> options) :base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
