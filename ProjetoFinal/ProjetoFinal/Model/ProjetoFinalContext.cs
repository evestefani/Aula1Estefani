using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Model
{
    public class ProjetoFinalContext : DbContext
    {
        public ProjetoFinalContext(DbContextOptions<ProjetoFinalContext> options)
            : base(options)
        { 
        }

        public ProjetoFinalContext()
        { 
        
        }
     public DbSet<Usuario> Usuarios { get; set; }
    }
}
