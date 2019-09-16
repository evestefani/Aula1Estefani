using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoPorMetodoConsultaCarroEIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsultaCarros();
            ListarValoresMaiorIdade();
        }
        

        private static void ConsultaCarros()
        {
            //Base de informações
            var conteudo = "carro:Gol,marca:volkswagen,ano:2000;carro:Jetta,marca:volkswagen,ano:2012;carro:Sportage,marca:Kia,ano:2011;carro:Hb20,marca:hyundai,ano:2015";

            ListarInformacoesPorNome(conteudo);

            Console.WriteLine("Digite o nome do carro para a busca:");
            var nomeCarro = Console.ReadLine();

            var veiculoSelecionado = RetornaVeiculo(conteudo, nomeCarro);

            Console.WriteLine(string.Format("O carro {0} é da marca {1} fabricado no ano {2}", veiculoSelecionado));

            Console.ReadKey();
        }

        private static void ListarInformacoesPorNome(string conteudo)
        {
            var listaDeInformacoes = conteudo.Split(';');

            foreach (var item in listaDeInformacoes)
            {
                var separandoInformacoes = item.Split(',');
                var nomeCarro = separandoInformacoes[0].Split(':')[1];

                Console.WriteLine($"Nome do carro {nomeCarro}");
            }
        }

        private static string[] RetornaVeiculo(string conteudo, string nomeVeiculo)
        {
            var listaDeInformacoes = conteudo.Split(';');

            foreach (var item in listaDeInformacoes)
            {
                var separandoInformacoes = item.Split(',');

                var nomeDoCarro = ObterValor(separandoInformacoes[0]);

                if (nomeDoCarro == nomeVeiculo)
                    return separandoInformacoes;
            }

            return new string[0];
        }
        private static string ObterValor(string colecao)
        {
            return colecao.Split(':')[1];
        }



        private static void ListarValoresMaiorIdade()
        {
            var conteudo = "nome:Felipe,idade: 27; nome: Giomar,idade: 17; nome: Edson,idade: 19; nome: Ericledson,idade: 75; nome: Junior,idade: 45";

            var listaDeConteudo = conteudo.Split(';');

            foreach (var item in listaDeConteudo)
            {
                var quebraInformacao = item.Split(',');
                var idade = int.Parse(quebraInformacao[1].Split(':')[1]);
                var nome = quebraInformacao[0].Split(':')[1];

                if (idade >= 18)
                {
                    Console.WriteLine($"Nome: {nome} Idade: {idade}");
                }

            }
        }

    }
}
