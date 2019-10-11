using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoFlores.Model;
using ListandoFlores.Controller;

namespace InterfaceFloricultura
{
    class Program
    {
        static FloresController FloresController = new FloresController();

        static void Main(string[] args)
        {
            InserirNome();
            ListarNome();
            RelatorioFloricultura();
        }

        private static void InserirNome()

        {
            Console.WriteLine("\n--- Digite o nome de uma flor ---\n");
            var nomeentrada = Console.ReadLine();

            Console.WriteLine("\n--- Digite quantidade ---\n");
            var quantidade = int.Parse(Console.ReadLine());

            FloresController.InserirNomes(new Flores()
            {
                Nome = nomeentrada,
                Quantidade = quantidade
            });

            Console.WriteLine("\nNome cadastrado com sucesso!\n");

        }

        private static void ListarNome()
        {
            Console.WriteLine("\n--- Listar nomes ---");
            Console.WriteLine();


            FloresController.GetListaNomes().ToList<Flores>().ForEach(x => Console.WriteLine($"Id: {x.Id} - Nome: {x.Nome} - Quantidade: {x.Quantidade}"));

            Console.ReadKey();

        }

        private static void RelatorioFloricultura()
        {
            Console.WriteLine("\n--- Relatório ordenado da quantidade ---\n");

            FloresController.GetListaNomes().OrderByDescending(x => x.Quantidade).ToList().ForEach(x => Console.WriteLine($"Id: {x.Id} - Nome: {x.Nome} - Quantidade: {x.Quantidade}"));

            Console.WriteLine("\n--- Soma total das flores ---\n");
            Console.WriteLine(FloresController.GetListaNomes().Sum(x => x.Quantidade));

            Console.ReadKey();
        }
           
        




    }
}
