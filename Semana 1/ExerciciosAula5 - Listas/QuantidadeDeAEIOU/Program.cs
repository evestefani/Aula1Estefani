using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantidadeDeAEIOU
{
    class Program
    {
        static void Main(string[] args)
        {
      
            Console.WriteLine("Encontre o número das letras A,E,I,O,U no texto digitado:");
            var texto = Console.ReadLine();
            var countFind = 0;
            var countFind2 = 0;
            var countFind3 = 0;
            var countFind4 = 0;
            var countFind5 = 0;



            var letraA = texto.Length;

            for (int i = 0; i < letraA; i++)
                if (texto[i].ToString() == "a") countFind++;

            Console.WriteLine($"Quantidade total de a {countFind}");

            var letraE = texto.Length;

            for (int i = 0; i < letraE; i++)
                if (texto[i].ToString() == "e") countFind2++;

            Console.WriteLine($"Quantidade total de e {countFind2}");

            var letraI = texto.Length;

            for (int i = 0; i < letraI; i++)
                if (texto[i].ToString() == "i") countFind3++;

            Console.WriteLine($"Quantidade total de i {countFind3}");

            var letraO = texto.Length;

            for (int i = 0; i < letraO; i++)
                if (texto[i].ToString() == "o") countFind4++;

            Console.WriteLine($"Quantidade total de o {countFind4}");

            var letraU = texto.Length;

            for (int i = 0; i < letraU; i++)
                if (texto[i].ToString() == "u") countFind5++;

            Console.WriteLine($"Quantidade total de u {countFind5}");

            Console.ReadKey();

           












        }
    }
}
