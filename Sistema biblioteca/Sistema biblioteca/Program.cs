using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Texto informativo para conultar o livro pelo numero de resgistro do sistema
            Console.WriteLine("Informe o livre a ser consultado:");
            //Parte de codigo que recebe as informacoes de registro do livro e coloca variavel
            //numeroDoLivro para utilizar
            var numeroDoLivro = Console.ReadLine();
            //Aqui realizo a compracao das informacoes do livro com o que tenho disponivel em estoque
            if (numeroDoLivro == "123456")
            {
                //Informo que este livro ja esta locado
                Console.WriteLine("Livro indisponível!!!");
                Console.ReadKey();
                //Finaliza o metodo
                return;
            }
            else
            {
                Console.WriteLine("Deseja alocar o livro? (1)Sim (2)Não");
                var resposta = Console.ReadLine();
                if (resposta == "1")

                {
                    Console.WriteLine("Livro alocado!");
                    Console.ReadKey();
                    return;
                }


                Console.ReadKey();
            }
         


          



        }
    }
}
