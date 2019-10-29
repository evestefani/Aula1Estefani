using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForeachComSplit();
            ForeachComSplitList();
        }

        /// <summary>
        /// metodo que mostra como podemos utilizar o foreach para andar sobre uma array de caracteres, ou seja, um texto ou palavra...
        /// </summary>
        private static void IniciandoForeach01() {
            
            Console.WriteLine("Infomrar o texto!");
            var conteudoDoTexto = Console.ReadLine();

            foreach (var item in conteudoDoTexto)
            {
                if (item == 'e') //neste caso do foreach se eu informar uma letra ela vai desaparecer no nome
                    continue;
                Console.WriteLine(item);

              Console.ReadKey();
            }
      }

        /// <summary>
        /// Metodo de busca com split e informando o nome
        /// </summary>
        private static void ForeachComSplit()
        {
            Console.WriteLine("Informe o seu nome");

            //var seunome = "Estefani";
            var conteudoDoTexto = $"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleção;e;vamos;colocar;isto;{Console.ReadLine()};para;depois;usar;com;o;replace";
            //var conteudoTextoSplit = conteudoDoTexto.Replace(';', ' ');
            //Console.WriteLine(conteudoTextoSplit);

            //var conteudoDoTexto = "Aqui vou colocar meu nome Estefani para realizar a busca";
            Console.WriteLine("Informe a palavra para realizar a busca");
            var palavra = Console.ReadLine();

            var conteudoTextoSplit = conteudoDoTexto.Split(';'); //split é usado para separar as palavras na busca

            foreach (var item in conteudoTextoSplit)
            {
                if (palavra == item)
                    Console.WriteLine("Palavra encontrada com sucesso!");


            }
            Console.ReadKey();
        }         

        private static void ForeachComSplitList()
        {
            var conteudo = "nome:Estefani,idade:31;nome:Tara,idade:25;nome:Ella,idade:18";

            var listOfInformation = conteudo.Split(';');

            Console.WriteLine("Usúarios cadastrados no sistema:");
            
            foreach (var item in listOfInformation)
            {
                Console.WriteLine(item.Split(',')[0]); 

            }
            Console.WriteLine("Informe um nome do sistema");
            var nomeBusca = Console.ReadLine();

            foreach (var item in listOfInformation)
            {
                var informacoesSplit = item.Split(',');

                var nome  = informacoesSplit[0].Split(':')[1];
                var idade = informacoesSplit[1].Split(':')[1];

                if (nome == nomeBusca)
                {
                    Console.WriteLine($"O {nome} está com {idade} anos de idade.");
                }
            }

            Console.ReadKey();
        }

       
    }
}       

        




            

    

