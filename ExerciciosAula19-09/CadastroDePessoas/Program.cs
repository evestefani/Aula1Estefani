using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDePessoas.Model;
using System.Globalization;

namespace CadastroDePessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro();
            while (Continuar() == 1)
            {
                Cadastro();
            }

        }

        private static int Continuar()
        {

            Console.WriteLine("Cadastrar mais pessoas? 1(SIM) 2 (NÃO)");
            return int.Parse(Console.ReadKey().KeyChar.ToString());
        }

       private static void Cadastro()
        
        {
            Console.WriteLine("-----Cadastramento de Pessoas------");
            Console.WriteLine();

            var listaDeCadastramento = new List<Pessoa>();

            Console.WriteLine("Cadastre as seguintes informações: ");
     
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Sexo: ");
            char sexo = char.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine("Altura: ");
            double altura = double.Parse(Console.ReadLine());

            listaDeCadastramento.Add(new Pessoa
            {
                Nome = nome,
                Idade = idade,
                Sexo = sexo,
                Altura = altura
            }) ;

            listaDeCadastramento.ForEach(item => Console.WriteLine($"Nome: {item.Nome.ToUpper()} possui {item.Idade} de idade, é do sexo {item.Sexo} e tem {item.Altura.ToString("F2", CultureInfo.InvariantCulture)} de altura"));
            Console.WriteLine("Cadastro efetuado com sucesso!");
            Console.ReadKey();

        }   
    }
}
