using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //chamamos nossa função
            SomarInteiroPrimitivos();

            SomaInteirosLista();

            SomaBalasListaDeCriancas();

            Console.ReadKey();
        }

        /// <summary>
        /// Metódo que mostra números inteiros por um tipo primitivo
        /// </summary>
        private static void SomarInteiroPrimitivos()
        {
            //quando utilizamos "[]" em um tipo "primitivo" podemos criar uma coleção destes valores
            int[] colecaoInteiros =

            //alocamos em memória para nossa coleção de valor, e informamos a quantidade de memória que vamos ocupar  
            //memoriaOcupadaInt * quantidadeInformada
            new int[5] 

            //aqui carregamos nossa coleção de valores
            { 1, 2, 3, 4, 5 };

            //Aqui somamos os valores em nossa lista //Sum faz a soma dos números inteiros 
            Console.WriteLine(colecaoInteiros.Sum());
        }

        /// <summary>
        /// Metódo que soma valores um à um em uma lista
        /// </summary>
        private static void SomaInteirosLista()
        {
            List<int> listaDEInteiros = new List<int>()
            {
                //Nossa coleção de valores
                1,2,3,4,5,6,7,8,9,10,11,12
            };

            Console.WriteLine(listaDEInteiros.Sum());
        }

        /// <summary>
        /// Metódo que soma a quantidade de balas das crianças
        /// </summary>
        private static void SomaBalasListaDeCriancas()
        {
            //Nossa lista de crianças foi criada e carregada em memória
            List<Crianca> criancas = new List<Crianca>()
            {
                //criando uma nova crinaça dentro da minha lista
                new Crianca()
                {
                    Nome = "Ella", //neste caso usamos a vírgula apenas para separar uma prorpriedade de outra
                    Balas = 9
                },//com a vírgula separamos um objeto de outro

                new Crianca()
                {
                    Nome = "Erick",
                    Balas = 68
                },
            };
            Console.WriteLine("Quantidade total de balas que as criancinhas levaram da venda");
            Console.WriteLine(
            //Soma a nossa quantidade de balas
            criancas.Sum(x => x.Balas));

        }
    }
}
