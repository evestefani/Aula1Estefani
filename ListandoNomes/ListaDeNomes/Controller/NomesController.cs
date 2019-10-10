using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaDeNomes.Model;

namespace ListaDeNomes.Controller
{
     public class NomesController
    {
        NomeContextDB NomesContext = new NomeContextDB();

        public bool InserirNomes(Nomes item)
        {

            if (string.IsNullOrWhiteSpace(item.Nome))
                return false;

            NomesContext.Nomes.Add(item);
            NomesContext.SaveChanges();

            return true;
 

        }
        public IQueryable<Nomes> GetListaNomes()
        {
            return NomesContext.Nomes;
        }
    }
}
