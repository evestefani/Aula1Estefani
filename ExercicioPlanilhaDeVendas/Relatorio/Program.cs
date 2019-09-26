using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeitorDeDadosDeVendas.Controller;
using System.Threading;

namespace InterfaceVendas
{
    class Program
    {
        static VendasController vendasController = new VendasController();
       

        static void Main(string[] args)
        {

            Console.WriteLine(" -------* Relátorio de Vendas *--------");
            Console.WriteLine();

            RelatorioPorPeriodo();


        }


        private static void RelatorioPorPeriodo()
        {



        }

       
    }                   
    
}
