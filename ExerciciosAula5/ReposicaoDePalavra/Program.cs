using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposicaoDePalavra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um texto");
            var textContent = Console.ReadLine();

            Console.WriteLine(textContent.Replace("banana", "laranja"));
            Console.ReadKey();
        }
    }
}
