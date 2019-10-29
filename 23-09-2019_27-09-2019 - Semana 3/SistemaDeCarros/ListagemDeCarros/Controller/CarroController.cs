using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Model;

namespace ListagemDeCarros.Controller
{
    public class CarroController
    {
        private SistemaCarrosContext carrosContext = new SistemaCarrosContext();

        /// <summary>
        /// Metódo que retorna a nossa lista de carros completa
        /// </summary>
        /// <returns>Retorna nossa lista de carros</returns>
        public List<Carro> RetornaListaDeCarros()
        {
            return carrosContext.ListaDeCarrosPublica;
        }
    }
}
 