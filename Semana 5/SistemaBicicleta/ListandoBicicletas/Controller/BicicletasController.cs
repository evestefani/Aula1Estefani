using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoBicicletas.Model;

namespace ListandoBicicletas.Controller
{
    public class BicicletasController
    {
        BicicletasContextDB BicicletasContext = new BicicletasContextDB();


        public bool InserirBicicletas(Bicicletas item) //BONUS
        {

            if (string.IsNullOrWhiteSpace(item.Modelo))
                return false;

            if (string.IsNullOrWhiteSpace(item.Marca))
                return false;

            if (item.Valor <= 0) 
                return false; 

            BicicletasContext.Bicicletas.Add(item);
            BicicletasContext.SaveChanges();

            return true;


        }

        public bool AtualizarBicicleta(Bicicletas item)
        {
            var bike = BicicletasContext.Bicicletas.FirstOrDefault(x => x.ID == item.ID);

            if (bike == null) 
                return false; 
            else
            {
                item.DataAlteracao = DateTime.Now;
            }

            BicicletasContext.SaveChanges(); 

            return true; 
        }

        public bool RemoverBicicleta(int id)
        {
            
            var bike = BicicletasContext.Bicicletas.FirstOrDefault(x => x.ID == id);

            if (bike == null) 
                return false; 

            bike.Ativo = false; 

            BicicletasContext.SaveChanges(); 

            return true; 
        }

        public IQueryable<Bicicletas> GetBicicletas()
        {
            return BicicletasContext.Bicicletas.Where(x => x.Ativo == true);
        }
    }
}
