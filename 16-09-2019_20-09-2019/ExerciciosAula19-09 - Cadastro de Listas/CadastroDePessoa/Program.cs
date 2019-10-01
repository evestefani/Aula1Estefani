using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDePessoa.Model;
using System.Globalization;

namespace CadastroDePessoa
{
    class Program
    {
        static List<Pessoa> pessoas = new List<Pessoa>();

        static void Main(string[] args) //void metodo sem retorno, sem resposta, ele faz só processamento
        {
            Cadastro();
            while (Continuar() == 1)
            {
                Cadastro();
            }
            Imprimir();

            Console.ReadKey();
        }
        private static void Imprimir()
        {
            pessoas.ForEach(item => Console.WriteLine(item.ToString()));
        }


        private static int Continuar()
        {

            Console.WriteLine("Cadastrar mais pessoas? 1(SIM) 2 (NÃO)");

            return int.Parse(Console.ReadKey().KeyChar.ToString());
        }


        private static void Cadastro()

        {
            Console.WriteLine();
            Console.WriteLine("-----Cadastramento de Pessoas------");
            Console.WriteLine();




            var objetoPessoa = new Pessoa();
            Console.WriteLine("Informe o nome completo: ");
            objetoPessoa.Nome = Console.ReadLine().ToUpper();
            Console.WriteLine("Informe a idade: ");
            objetoPessoa.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o genêro: ");
            objetoPessoa.Sexo = char.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine("Informe a altura: ");
            objetoPessoa.Altura = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            pessoas.Add(objetoPessoa);

          

            

            Console.WriteLine("Cadastro efetuado com sucesso!");
            Console.WriteLine();
            Console.ReadKey();

        }

    }
}    


       
