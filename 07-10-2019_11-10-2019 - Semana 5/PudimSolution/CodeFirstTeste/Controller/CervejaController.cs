using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstTeste.Model;

namespace CodeFirstTeste.Controller
{
    public class CervejaController
    {
        CervejaContextDb contextDb = new CervejaContextDb(@"data source=(localdb)\MSSQLLocalDB;initial catalog=RevisandoEntity.Model.CervejaContextDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        public void AddCerveja(Cerveja item)
        {
            contextDb.Cervejas.Add(item);
            contextDb.SaveChanges();
        }
    }
}
