using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompactarTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeiroTexto = "Hi we can do whatever we want, cool!";

            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contem: {primeiroTexto.Length} caracteres.");

            primeiroTexto = primeiroTexto
                .Replace("Hi", "1").Replace("we", "2").Replace("can", "3");

            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contem: {primeiroTexto.Length} caracteres.");

            primeiroTexto = primeiroTexto
                .Replace("1", "Hi").Replace("2", "we").Replace("3", "can").Replace("", "");

            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contem: {primeiroTexto.Length} caracteres.");




            Console.ReadKey();




        }
    }


}
