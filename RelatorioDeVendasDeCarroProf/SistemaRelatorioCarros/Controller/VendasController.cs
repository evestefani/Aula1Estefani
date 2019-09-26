using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorioCarros.Model;

namespace SistemaRelatorioCarros.Controller
{

    public class VendasController
    {
        SistemaVendasContext vendasContext = new SistemaVendasContext();

        /// <summary>
        /// Método que retorna a lista de vendas, caso não informar o valor ele retorna a lista sem filtro
        /// </summary>
        /// <param name="mes">Mês para realizar o filtro</param>
        /// <returns>Lista filtrada ou não dependendo do parametro do usuário</returns>
        public List<Venda> GetVendas(int mes = 0)
        {
            if (mes == 0)
                //Retornamos a nossa lista de vendas sem nenhum filtro neste momento
                return vendasContext.ListaVendasPublica;
            else
                //Retornamos a nossa lista de vendas com o filtro pelo mês informado
                return vendasContext.ListaVendasPublica.FindAll(x => x.Data.Month == mes);
        }


    }

     

}



