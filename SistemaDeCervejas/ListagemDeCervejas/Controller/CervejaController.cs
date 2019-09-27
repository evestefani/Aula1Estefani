using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Model;

namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
        SistemaCervejaContext sistemaCervejaContext = new SistemaCervejaContext();
        
        /// <summary>
        /// Método que retorna as informações da minha lista de cervejas
        /// </summary>
        /// <returns>retorna as cervejas da minha lista</returns>
        public List<Cerveja> RetornaListaDeCervejas ()
        {
            return sistemaCervejaContext.ListaDeCervejasPublica;
        }
        
        /// <summary>
        /// Metódo que adiciona cervejas à minha lista
        /// </summary>
        /// <param name="cerveja">É dado as informações para a cerveja, como nome</param>
        public void AdicionarCervejasALista (Cerveja cerveja)
        {
            cerveja.Id = sistemaCervejaContext.IdContador++;
            sistemaCervejaContext.ListaDeCerveja.Add(cerveja);
        }
        /// <summary>
        /// Metódo que retorna a soma total dos valores das cervejas da minha lista
        /// </summary>
        /// <returns>Retorna o valor total</returns>
        public double RetornaValorTotalCervejas ()
        {
            return sistemaCervejaContext.ListaDeCerveja.Sum(x => x.Valor);
        }

        /// <summary>
        /// Metódo que retorna o total de litros de cerveja da minha lista
        /// </summary>
        /// <returns>Retorna a quantidade de litros</returns>
        public double RetornaValorTotalLitrosCervejas ()
        {
            return sistemaCervejaContext.ListaDeCerveja.Sum(x => x.Litros);
        }

   
    }
}
