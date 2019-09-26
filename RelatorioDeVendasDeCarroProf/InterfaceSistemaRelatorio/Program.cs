using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorioCarros.Controller;
using SistemaRelatorioCarros.Model;

namespace InterfaceSistemaRelatorio
{
    class Program
    {
        static VendasController vendasController = new VendasController();


        static void Main(string[] args)
        {
            Console.WriteLine("--- * Informações das vendas realizadas duarante o ano de 2019 * ---");
            Console.WriteLine();
            vendasController.GetVendas().ForEach(item => ImprimeInformacoes(item));

            Console.ReadKey();

            MostraMenuRelatorio();

           
        }

        /// <summary>
        /// Metódo que mostra o menu do sistema
        /// </summary>
        private static void MostraMenuRelatorio()
        {
            Console.Clear();
            Console.WriteLine("< Menu de relatórios >");
            Console.WriteLine("1 - Menu por período mensal");
            Console.WriteLine("0 - Sair");

            var menuEscolhido = int.MinValue;

            while (menuEscolhido !=0)
            {
                menuEscolhido = int.Parse(Console.ReadLine());
                switch (menuEscolhido)
                {
               
                    case 1:
                        {
                            Console.WriteLine("Informe o mês para realizar o filtro");

                            //Obtemos a informação do mês
                            var mesEscolhido = int.Parse(Console.ReadLine());
                            //Passamos o mês na mesma função para obter as vendas
                            var listaDoPeriodoEscolhido = vendasController.GetVendas(mesEscolhido);

                            //Aqui imprimimos as informações para o usuário
                            listaDoPeriodoEscolhido.ForEach(item => ImprimeInformacoes(item));

                            var totalMes = listaDoPeriodoEscolhido
                            //Somamos todos os registros multiplicando os valores venda vezes a quantidade
                            .Sum(x => x.Valor * x.Quantidade);
                            //Mostramos o mês escolhido e o valor total neste mês gerado
                            //Mostramos o mês escolhido e o valor total neste mês gerado
                            Console.WriteLine($"Total do mês {mesEscolhido} é {totalMes.ToString("C")}");

                            var mediaPeriodo = listaDoPeriodoEscolhido
                            //Média de todos os registros multiplicando os valores venda vezes a quantidade
                            .Average(x => x.Valor * x.Quantidade);
                            //Mostramos o mês escolhido e a média de vendas gerada neste mês
                            Console.WriteLine($"Média do mês {mesEscolhido} é {mediaPeriodo.ToString("C")}");


                            Console.ReadKey();
                        }
                        break;
                }
            }

        }

        /// <summary>
        /// Metódo para imprimir as informações do relatório
        /// </summary>
        /// <param name="vendas">Pega as informações do nosso relatório no context</param>
        public static void ImprimeInformacoes(Venda vendas)
        {
            Console.WriteLine(string.Format("Id {0,-5} Carro {1,-37} Valor {2,-13} Quantidade {3,-7} Data {4,-8}"
                ,vendas.Id
                ,vendas.Carro
                ,vendas.Valor.ToString("C")
                ,vendas.Quantidade
                ,vendas.Data.ToShortDateString()));
        }
    }

}
