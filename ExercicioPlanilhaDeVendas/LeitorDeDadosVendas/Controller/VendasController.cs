using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeitorDeDadosVendas.Model;


namespace LeitorDeDadosVendas.Controller
{
    public class VendasController
    {
        RelatorioContext relatorio = new RelatorioContext();

        private static void SomaDasVendasPorPeriodo()
        {
            List<ListaDeVendas> listaDeVendas = new List<ListaDeVendas>();

            Console.WriteLine("Quantidade total de vendas referente ao período: ");
            Console.WriteLine(listaDeVendas.Sum(x => x.Valor));
        }

        private static void MediaDasVendasPorPeriodo()

        {
            List<ListaDeVendas> listaDeVendas = new List<ListaDeVendas>();


            Console.WriteLine("Média de vendas R$: ");
            Console.WriteLine(listaDeVendas.Average(x => x.Quantidade * x.Valor));

            Console.ReadKey();

        }   
}   }
