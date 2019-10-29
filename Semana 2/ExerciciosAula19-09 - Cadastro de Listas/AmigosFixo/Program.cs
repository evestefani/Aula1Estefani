using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmigosFixo.Model;

namespace AmigosFixo
{
    class Program
    {
        static void Main(string[] args) // metodo static significa que voce pode chamar ele pela class
        {
            var listaDeAmigos = new List<Amigos>
            {
                new Amigos()
                {
                    Nome = "Ella",
                    TempoDeAmizade = 20
                },
                new Amigos()
                {
                    Nome = "Charlene",
                    TempoDeAmizade = 13
                },
                new Amigos()
                {
                    Nome = "Tara",
                    TempoDeAmizade = 31
                },
            };
            listaDeAmigos.ForEach(item => Console.WriteLine($" Nome: {item.Nome}, o tempo de amizade: {item.TempoDeAmizade} anos"));

            Console.ReadKey();



        }
    }
}
