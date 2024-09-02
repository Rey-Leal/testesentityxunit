using Microsoft.EntityFrameworkCore;
using EntityMVC.Models;

namespace EntityMVC.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Grupo> Grupo { get; set; } = default!;
        public DbSet<Produto> Produto { get; set; } = default!;
        public DbSet<Usuario> Usuario { get; set; } = default!;
    }
}
