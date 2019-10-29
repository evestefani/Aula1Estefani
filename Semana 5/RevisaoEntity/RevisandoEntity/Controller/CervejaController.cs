using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisandoEntity.Model;

namespace RevisandoEntity.Controller
{
    // Primeiro deixar a class public
    public class CervejaController
    {
        // Iniciamos nossa base de dados no controller
        CervejaContextDB contextDB = new CervejaContextDB();

        // Esse metódo faz com que o usuário obrigue a utilizar a palavra Cerveja para cadastrar a informação no banco de dados, lembrando que a palavra precisar ser escrita exatamente como foi passada
        public void AddCerveja(Cerveja item)
        {
            if (item.Nome.Contains("Cerveja"))
            {
                contextDB.Cervejas.Add(item);

                contextDB.SaveChanges();
            }
          
        }

        public IQueryable<Cerveja> GetCervejas()

        {
            return contextDB.Cervejas.Where(x => x.Nome.Contains("Cerveja"));
        }

    }
}
