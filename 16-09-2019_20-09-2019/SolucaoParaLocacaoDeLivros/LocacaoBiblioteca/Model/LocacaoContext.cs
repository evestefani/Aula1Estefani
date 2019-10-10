using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext : DbContext

    {
        /// <summary>
        /// metodo condutor que prepara nossa classe LocacaoContext
        /// </summary>
        public LocacaoContext()
        {

        }
        public DbSet<Livro> Livros { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

}   }

