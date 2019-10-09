using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalagoCelulares.Model
{
    public class CelularesContextDB : DbContext // Com o 'DbContext' vamos herdar toda a caixa de ferramentas do EntityFramework
    {
        // Definimos nossas tabelas no banco de dados (DbSet)

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Celular> Celulares {get; set;}

      }
}
