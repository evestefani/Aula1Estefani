
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaSegundaClass.Model;


namespace MinhaSegundaClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var minhaCestaDeFrutas = new List<Frutas>
            {
                new Frutas
                {
                    Nome = "Bananas",
                    Quantidade = 5
                },

                new Frutas
                {
                    Nome = "Maças",
                    Quantidade = 2
                },

                new Frutas
                {
                    Nome = "Uvas",
                    Quantidade = 2
                }
            };

            minhaCestaDeFrutas.ForEach(item => Console.WriteLine($"Nome de frutas > Fruta: {item.Nome} Quantidade {item.Quantidade}"));

            Console.ReadKey();




        }
    }
}
