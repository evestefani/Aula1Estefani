using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaDeNomes.Model;
using ListaDeNomes.Controller;

namespace InterfaceListaDeNomes
{
    class Program
    {
        static NomesController NomesController = new NomesController();

        static void Main(string[] args)
        {
            InserirNome();
            ListarNome();
        }

        public static void InserirNome()

        {
            Console.WriteLine("\n--- Digite um nome ---\n");
            var nomeentrada = Console.ReadLine();

            NomesController.InserirNomes(new Nomes()
            {
                Nome = nomeentrada
            });

            Console.WriteLine("\nNome cadastrado com sucesso!\n");

        }

        public static void ListarNome()
        {
            Console.WriteLine("\n--- Listar nomes ---");
            Console.WriteLine();


            NomesController.GetListaNomes().ToList<Nomes>().ForEach(x => Console.WriteLine($"Id: {x.ID} Nome: {x.Nome}"));

            Console.ReadKey();

        }



    }
}
