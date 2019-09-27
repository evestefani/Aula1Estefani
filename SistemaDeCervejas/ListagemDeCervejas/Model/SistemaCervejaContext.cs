using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;

namespace ListagemDeCervejas.Model
{
    public class SistemaCervejaContext
    {
        public int IdContador = 1;
        public List<Cerveja> ListaDeCerveja { get; set;}

        public SistemaCervejaContext ()
        {
            ListaDeCerveja = new List<Cerveja>();

            ListaDeCerveja.Add(new Cerveja() { Id = IdContador++, Nome = "Skol", Litros = 0.600, Alcool = 4.5, Valor = 10.00 });
            ListaDeCerveja.Add(new Cerveja() { Id = IdContador++, Nome = "Brahma", Litros = 0.600, Alcool = 4.6, Valor = 13.00 });
            ListaDeCerveja.Add(new Cerveja() { Id = IdContador++, Nome = "Budweiswer", Litros = 0.350, Alcool = 5, Valor = 2.90 });
            ListaDeCerveja.Add(new Cerveja() { Id = IdContador++, Nome = "Red Stripe", Litros = 0.550, Alcool = 5, Valor = 6.90 });
            ListaDeCerveja.Add(new Cerveja() { Id = IdContador++, Nome = "Corona", Litros = 0.400, Alcool = 4.8, Valor = 5.95 });

        }

        public List<Cerveja> ListaDeCervejasPublica { get { return ListaDeCerveja;}}


    }  
   


}

       


   
    
        
