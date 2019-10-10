using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoFlores.Model;

namespace ListandoFlores.Controller
{
     
     public class FloresController
    {
        FloresContextDB FloresContext = new FloresContextDB();

        public bool InserirNomes(Flores item)
        {

            if (string.IsNullOrWhiteSpace(item.Nome))
                return false;

            FloresContext.Flores.Add(item);
            FloresContext.SaveChanges();

            return true;


        }
        public IQueryable<Flores> GetListaNomes()
        {
            return FloresContext.Flores;
        }
    }
}
