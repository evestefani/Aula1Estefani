using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            ModeloMarcaAnoCarro();
        }

        private static void ModeloMarcaAnoCarro()
        {
            var conteudo = "Veículo:Gol,ano:1998,marca:Volkswagen;Veículo:Ranger,ano:1998,marca:Ford;Veículo:Sandero,ano:2014,marca:Renault";

            var lista = conteudo.Split(';');

            Console.WriteLine("Veículos cadastrados no sistema:");

            foreach (var item in lista)
            {
                Console.WriteLine(item.Split(',')[0]);

            }
            Console.WriteLine("Informe o véiculo do sistema:");
            var nomeBusca = Console.ReadLine();

            foreach (var item in lista)
            {
                var informacoesSplit = item.Split(',');

                var modelo = informacoesSplit[0].Split(':')[1];
                var ano = informacoesSplit[1].Split(':')[1];
                var marca = informacoesSplit[2].Split(':')[1];

                if (modelo == nomeBusca)

                {
                    var anoVeiculo = DateTime.Now.Year;
                    var idadeVeiculo = (anoVeiculo - int.Parse(ano));
                    Console.WriteLine($"O {modelo} do ano {ano} fabricado pela {marca} está disponível para venda!");
                    Console.WriteLine($"O {modelo} da {marca} está atualmente com {idadeVeiculo} anos de uso!");
                }

                Console.ReadKey();
            }
        }

        
        
       
    }
            
               
            
        
    
}
