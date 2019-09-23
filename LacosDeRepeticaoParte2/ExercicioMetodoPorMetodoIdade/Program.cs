using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMetodoPorMetodoIdade


{
    class Program
    {
        static void Main(string[] args)
        {
            ConsultaDeIdade();
        }

        private static void ConsultaDeIdade()
        {
            var conteudo = "nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";

            ListarInformacoes(conteudo);

            Console.ReadKey();
        }

        private static void ListarInformacoes(string conteudo)
        {
            var listaDeInformacoes = conteudo.Split(';');

            foreach (var item in listaDeInformacoes)
            {
                var separandoInformacoes = item.Split(',');
                var nomepessoa = separandoInformacoes[0].Split(':')[1];
                var idade = separandoInformacoes[1].Split(':')[1];

                if (int.Parse(idade) >= 18)
                    Console.WriteLine($"{nomepessoa} com idade de {idade} é uma pessoa maior de 18 anos!");


            }
            Console.ReadKey();


        }








        //    {
        //        Console.WriteLine(item.Split(',')[0]);

        //    }
        //    Console.WriteLine("Informe o véiculo do sistema:");
        //    var nomeBusca = Console.ReadLine();

        //    foreach (var item in lista)
        //    {
        //        var informacoesSplit = item.Split(',');

        //        var modelo = informacoesSplit[0].Split(':')[1];
        //        var ano = informacoesSplit[1].Split(':')[1];
        //        var marca = informacoesSplit[2].Split(':')[1];

        //        if (modelo == nomeBusca)

        //        {
        //            var anoVeiculo = DateTime.Now.Year;
        //            var idadeVeiculo = (anoVeiculo - int.Parse(ano));
        //            Console.WriteLine($"O {modelo} do ano {ano} fabricado pela {marca} está disponível para venda!");
        //            Console.WriteLine($"O {modelo} da {marca} está atualmente com {idadeVeiculo} anos de uso!");
        //        }

        //        Console.ReadKey();
        //    }
        //}




    }





}
