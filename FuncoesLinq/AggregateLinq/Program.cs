using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeNomes = new List<string>()
            {
                "Estéfani",
                "Giomar",
                "Euricledson",
                "Adagoberto",
                "Ezbio",
                "Irineudson"
            };

            var texto = listaDeNomes.
           //Aggregate agrega um por um o nome da sua lista, tendo o nome atual e o próximo nome da lista
           //No passo seguinte temos o nome próximo", ele vira o atual e pega o próximo nome da lista após o atual
           Aggregate((nome1, nome2) => nome1 + ";\r\n" + nome2);
            

            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}
