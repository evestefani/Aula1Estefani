using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextoPrimeiroEUltimoCaractere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o texto");
            var texto = Console.ReadLine();


            var primeiraletra = texto[0].ToString();
            var ultimaletra = texto[texto.Length - 1].ToString();

            Console.WriteLine($" A primeira letra é {primeiraletra} e a segunda letra é {ultimaletra}");
            Console.ReadKey();



        }
    }
}
