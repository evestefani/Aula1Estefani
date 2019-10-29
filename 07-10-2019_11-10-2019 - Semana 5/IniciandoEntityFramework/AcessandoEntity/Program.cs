using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Controller;
using EntityClass.Model;

namespace AcessandoEntity
{
    class Program
    {
        static PessoaController pessoa = new PessoaController();

        static void Main(string[] args)
        {
           pessoa.AddPessoa( // Aqui utilizamos o metódo da controller para adicionar a pessoa nossa lista
           new Pessoa() // Adiciona a pessoa em nossa lista
           {
               Nome = "Estefani" // Novo registro
           });                   // O metódo AddPessoas tem o SvaChanges que realiza a gravação das informações em nosso banco de dados

            pessoa.GetPessoas(). // Obtemos a lista de pessoas
            ToList<Pessoa>(). // Convertemos para uma lista de pessoas
            ForEach(x => Console.WriteLine(x.Nome)); // Mostramos em nosso console

            Console.ReadKey();
        }
    }
}
