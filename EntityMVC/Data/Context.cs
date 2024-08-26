using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestesEntityMVC.Models;

namespace TestesEntityMVC.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<TestesEntityMVC.Models.Grupo> Grupo { get; set; } = default!;
        public DbSet<TestesEntityMVC.Models.Produto> Produto { get; set; } = default!;
        public DbSet<TestesEntityMVC.Models.Usuario> Usuario { get; set; } = default!;
    }
}
