using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<EntityMVC.Models.Grupo> Grupo { get; set; } = default!;
        public DbSet<EntityMVC.Models.Produto> Produto { get; set; } = default!;
        public DbSet<EntityMVC.Models.Usuario> Usuario { get; set; } = default!;
    }
}
