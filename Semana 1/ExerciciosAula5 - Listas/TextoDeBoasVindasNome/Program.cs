using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextoDeBoasVindasNome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boas Vindas");
            Console.ReadKey();

            string nome = string.Empty;

            nome = AskToName();

            Console.WriteLine($" Boas vindas, {nome}");
            Console.ReadKey();

        }

        private static string AskToName()
        {
            Console.WriteLine("Qual o seu nome completo?");
            return Console.ReadLine();
        }

    } 
}
