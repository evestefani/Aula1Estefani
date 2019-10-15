using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeInformacoes = new List<Pessoas>();

            listaDeInformacoes.Add(new Pessoas(){Id = 1, Nome = "Spear", DataDeNascimento = DateTime.Parse("07/11/2004"), ValorNaCarteira = 846.96});
            listaDeInformacoes.Add(new Pessoas(){Id = 2, Nome = "Swanson", DataDeNascimento = DateTime.Parse("20/06/2003"), ValorNaCarteira = 233.09});
            listaDeInformacoes.Add(new Pessoas(){Id = 3, Nome = "Gregory", DataDeNascimento = DateTime.Parse("02/01/2000"), ValorNaCarteira = 469.01});
            listaDeInformacoes.Add(new Pessoas(){Id = 4, Nome = "Olson", DataDeNascimento = DateTime.Parse("18/07/2001"), ValorNaCarteira = 261.90});
            listaDeInformacoes.Add(new Pessoas(){Id = 5, Nome = "Garza", DataDeNascimento = DateTime.Parse("01/04/2000"), ValorNaCarteira = 360.41});
            listaDeInformacoes.Add(new Pessoas(){Id = 6, Nome = "Sweet", DataDeNascimento = DateTime.Parse("12/03/2003"), ValorNaCarteira = 312.76});
            listaDeInformacoes.Add(new Pessoas(){Id = 7, Nome = "Cline", DataDeNascimento = DateTime.Parse("26/03/2002"), ValorNaCarteira = 484.51});
            listaDeInformacoes.Add(new Pessoas(){Id = 8, Nome = "Oliver", DataDeNascimento = DateTime.Parse("05/07/2004"), ValorNaCarteira = 513.76});
            listaDeInformacoes.Add(new Pessoas(){Id = 9, Nome = "Vang", DataDeNascimento = DateTime.Parse("10/07/2000"), ValorNaCarteira = 271.05});
            listaDeInformacoes.Add(new Pessoas(){Id = 10, Nome = "Maddox", DataDeNascimento = DateTime.Parse("29/05/2004"), ValorNaCarteira = 783.97});
            listaDeInformacoes.Add(new Pessoas(){Id = 11, Nome = "Garrett", DataDeNascimento = DateTime.Parse("03/06/2006"), ValorNaCarteira = 154.11});
            listaDeInformacoes.Add(new Pessoas(){Id = 12, Nome = "Mcintosh", DataDeNascimento = DateTime.Parse("06/07/2006"), ValorNaCarteira = 902.80});
            listaDeInformacoes.Add(new Pessoas(){Id = 13, Nome = "Yang", DataDeNascimento = DateTime.Parse("29/04/2005"), ValorNaCarteira = 550.48});
            listaDeInformacoes.Add(new Pessoas(){Id = 14, Nome = "Hnedricks", DataDeNascimento = DateTime.Parse("05/09/2003"), ValorNaCarteira = 410.56});
            listaDeInformacoes.Add(new Pessoas(){Id = 15, Nome = "Cain", DataDeNascimento = DateTime.Parse("12/01/2002"), ValorNaCarteira = 221.13});
            listaDeInformacoes.Add(new Pessoas(){Id = 16, Nome = "Blackburn", DataDeNascimento = DateTime.Parse("10/05/2000"), ValorNaCarteira = 135.67});
            listaDeInformacoes.Add(new Pessoas(){Id = 17, Nome = "Howe", DataDeNascimento = DateTime.Parse("27/09/2005"), ValorNaCarteira = 360.14});
            listaDeInformacoes.Add(new Pessoas(){Id = 18, Nome = "Pratt", DataDeNascimento = DateTime.Parse("18/09/2000"), ValorNaCarteira = 991.83});
            listaDeInformacoes.Add(new Pessoas(){Id = 19, Nome = "Sherman", DataDeNascimento = DateTime.Parse("20/02/2003"), ValorNaCarteira = 667.00});
            listaDeInformacoes.Add(new Pessoas(){Id = 20, Nome = "Gayri", DataDeNascimento = DateTime.Parse("03/12/2001"), ValorNaCarteira = 911.92 });

            Console.WriteLine("---------- Ordem crescente pelo nome ----------");
            Console.WriteLine();

            listaDeInformacoes.OrderBy(x => x.Nome).ToList<Pessoas>().ForEach(item => Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Nascimento: {item.DataDeNascimento} - Saldo: {item.ValorNaCarteira}"));

            Console.WriteLine();
            Console.WriteLine("---------- Ordem decrescente pela data de nascimento ----------");
            Console.WriteLine();

            listaDeInformacoes.OrderByDescending(x => x.DataDeNascimento).ToList<Pessoas>().ForEach(item => Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Nascimento: {item.DataDeNascimento} - Saldo: {item.ValorNaCarteira}"));

            Console.WriteLine();
            Console.WriteLine("---------- Listar as pessoas com mais de R$500,00 ----------");
            Console.WriteLine();

            var saldoNaCarteira = listaDeInformacoes.Where(x => x.ValorNaCarteira > 500).OrderBy(x => x.Nome);

            saldoNaCarteira.ToList<Pessoas>().ForEach(item => Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Nascimento: {item.DataDeNascimento} - Saldo: {item.ValorNaCarteira}"));


            Console.WriteLine();
            Console.WriteLine("---------- Listar as pessoas acima de 18 anos ----------");
            Console.WriteLine();

            foreach (var item in listaDeInformacoes)
            {
                var nascimento = DateTime.Now.Year - item.DataDeNascimento.Year;
                if (nascimento >= 18)

                Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Nascimento: {item.DataDeNascimento}");
            }
             

            Console.WriteLine();
            Console.WriteLine("---------- Listar as pessoas menores de 16 anos ----------");
            Console.WriteLine();

            foreach (var item in listaDeInformacoes)
            {
                var nascimento1 = DateTime.Now.Year - item.DataDeNascimento.Year;
                if (nascimento1 <= 16)

                {
                    Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Nascimento: {item.DataDeNascimento}");
                }
            }

            Console.ReadKey();
        }
    }
}
