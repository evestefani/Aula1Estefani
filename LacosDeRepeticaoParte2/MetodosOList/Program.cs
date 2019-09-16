using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosOList
{
    class Program
    {
        static List<string> minhaListaPulgmatica = new List<string>()

            {
                "Estefani",
                "Tara",
                "Ella",
            };
        static void Main(string[] args)

        {
            AdicionarItensALista();

            ListaInformacoes();

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que adiciona um item a lista
        /// </summary>
        private static void AdicionarItensALista()
        {
            Console.Clear();
            Console.WriteLine("Informe um nome");
            minhaListaPulgmatica.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Deseja informar mais valores? sim(S) não (N)");

            if (Console.ReadKey().KeyChar.ToString().ToLower() == "s") 
                AdicionarItensALista();
            
            
        }


        /// <summary>
        /// Metodo que mostra a lista
        /// </summary>
        private static void ListaInformacoes()
           
        {
            Console.Clear();
            Console.WriteLine("Nomes adicionados a lista");
            foreach (var item in minhaListaPulgmatica)
                Console.WriteLine($"Nome:{item} foi adicionado a listam");
        }
    }
}
