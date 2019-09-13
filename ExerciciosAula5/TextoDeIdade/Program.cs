using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextoDeIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            int age = 0;

            name = AskToName();
            age = AskToAge(name);
            Console.ReadKey();
        }

        private static string AskToName()
        {
            Console.WriteLine("Qual o seu nome?");
            return Console.ReadLine();
        }

        private static int AskToAge(string nome)
        {
            Console.WriteLine("Qual a sua idade?"); 
            int age = int.Parse(Console.ReadLine()); 
          
            if (age >= 18)
                Console.WriteLine($"Parabéns {nome} você já esta na fase adulta.");
            else
                Console.WriteLine($"Calma {nome} tudo ao seu tempo logo você terá 18 anos de idade");
            return age;

            
        }


    }
}
