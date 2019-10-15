using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;



namespace InterfaceSistemaCerveja
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();

        static void Main(string[] args)

        {
            cervejaController.RetornaListaDeCervejas().ForEach(item => Console.WriteLine($"Id: {item.Id}, Nome: {item.Nome}"));
          
            Console.WriteLine("Adicionar cervejas a lista:");
            Console.WriteLine("Nome da cerveja:");
            var nomeCerveja = Console.ReadLine();
            Console.WriteLine("Quantidade:");
            var litrosCerveja = double.Parse(Console.ReadLine());

            cervejaController.AdicionarCervejasALista(new Cerveja()

            {
                Nome = nomeCerveja,
                Litros = litrosCerveja
            });

            cervejaController.RetornaListaDeCervejas().ForEach(item => Console.WriteLine($"Nome: {item.Nome}, Litros  {item.Litros}"));

  

            Console.WriteLine(cervejaController.SomaValorDeCervejas());
            Console.WriteLine(cervejaController.SomaLitrosDeCervejas());

            Console.ReadKey();
        }


}   }