using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeNomes.Model
{
    public class NomeContextDB : DbContext
    {
        public DbSet<Nomes> Nomes { get; set; }
    }
}
