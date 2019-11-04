using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ExercicioRegistroImoveisCore.Model
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options)
                   : base(options)
        {

        }
        public WebApiContext()
        {

        }

        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Proprietario> Proprietarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }

}
