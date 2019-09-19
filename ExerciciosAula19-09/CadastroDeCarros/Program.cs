using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeCarros.Model;
using System.Globalization;

namespace CadastroDeCarros
{
    class Program
    {
        static List<Carro> carros = new List<Carro>();

        static void Main(string[] args)
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
            carros.ForEach(item => Console.WriteLine(item.ToString()));
        }


        private static int Continuar()
        {

            Console.WriteLine("Cadastrar outro automovél? 1(SIM) 2 (NÃO)");

            return int.Parse(Console.ReadKey().KeyChar.ToString());
        }


        private static void Cadastro()

        {
            Console.WriteLine();
            Console.WriteLine("-----Cadastramento de Automovéis------");
            Console.WriteLine();

           

            var objetoCarro = new Carro();
            Console.WriteLine("Informe a marca: ");
            objetoCarro.Marca = Console.ReadLine().ToUpper();
            Console.WriteLine("Informe o modelo: ");
            objetoCarro.Modelo = Console.ReadLine().ToUpper();
            Console.WriteLine("Informe o ano: ");
            objetoCarro.Ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor: ");
            objetoCarro.Valor = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            carros.Add(objetoCarro);
            
           


            Console.WriteLine("Cadastro efetuado com sucesso!");
            Console.WriteLine();
            Console.ReadKey();

        }



    }
}
