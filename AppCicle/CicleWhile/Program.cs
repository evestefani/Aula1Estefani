using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicleWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInitAppText(); //faz com que o texto jogado la embaixo no static void apareça por primeiro, isso para que haja menos processo de dados

            string nome = string.Empty;
            int age = 0;
            char gender = char.MinValue;
            string description = string.Empty;

            while (AskToContinue() == 1) // == significa que é igual
            {
                nome = AskToName(); //poder da fala
                age = AskYourAge(nome); //poder de ouvir
                gender = AskToGender();
                description = AskToDescription();



                Console.WriteLine($"Suas informações: Nome {nome} e sua idade {age} e seu sexo {gender}");
                Console.ReadKey();
                //Readkey faz com que mantenha o texto na tela e não finalize, segura o ciclo
                //$ significa que permite informar uma variavel (nome e age) na sua frase, deixa mais flexivel sua string
                Console.WriteLine("Muito obrigada pela conversa");
                Console.ReadKey();
            }

            // o comando acima seria todo o meu bloco de metodo 

        }

        /// <summary>
        /// Metodo para mostrar o texto inicial do sistema alone
        /// </summary>
        private static void ShowInitAppText()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("--Seja bem vindo!--");
            Console.WriteLine("-------------------");
        }


        /// <summary>
        /// Metodo para realizar a pergunta se deseja continuar
        /// </summary>
        /// <returns>retorna o valor que foi inserido (1 ou 2)</returns>
        private static int AskToContinue() //nome do metodo
        {
            Console.WriteLine("Vamos conversar? sim(1) não (2)");
            return int.Parse(Console.ReadKey().KeyChar.ToString());
            //Readkey sempre siginifca que ele esta esperando ser apertado uma tecla
            //KeyChar significa que é a letra de uma palavra, a letra que esta na tecla que voce aperta denomina que é 1 só caractere, portanto fara que leia somente um caractere
            //ToString vai transformar o numeral em um caracterer
            //Parse (passar) faz a conversão de um caratcter para numeral
        }
        private static int AskYourAge(string nome) //(stringnome) deu o poder de ouvir
        {
            Console.WriteLine("Quantos anos você têm?"); //pergunta do computador
            int age = int.Parse(Console.ReadLine()); //resposta do usuario
            //ReadLine fara com que leia mais de 1 caractere, sendo então a frase inteira
            if (age >= 18) 
            Console.WriteLine($" {nome} Você está habilitado para beber!");
            else
            Console.WriteLine("Só lamento, tente na próxima!");
            return age;

        }


        /// <summary>
        /// metodo para perguntar o nome
        /// </summary>
        /// <returns>retorna o nome informado</returns>
        private static string AskToName()
        {
            Console.WriteLine("Qual o seu nome?");
            return Console.ReadLine();
        }
        private static char AskToGender()
        {
            Console.WriteLine("Qual seu sexo? feminino(f) ou masculino(m)");
            return Console.ReadKey().KeyChar; //so retorna a letra da tecla pressionada
        }
        private static string AskToDescription()
        {
            Console.WriteLine("Como você se descreveria?");
            return Console.ReadLine();
            


            
                
           
            
        }
    } 

        
}
