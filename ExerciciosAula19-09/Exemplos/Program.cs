using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.

namespace Pessoas
{
    class Program
    {

        static bool PessoasQueNaoPodemSerPresas(Pessoa pes)
        {
            return pes.Idade < 18;
        }
        static void Main(string[] args)

            List<Pessoa> pessoas = new List<Pessoa>();

        Pessoa p1 = new Pessoa();
        p1.Nome = "Gabriel";
        p1.Sexo = 'M';
        p1 Altura = 2.01;
        p1.Idade = 29;

            pessoas.Add(p1)

        Pessoa p2 = new Pessoa();
        p2.Nome = "Elora";
        p2.Sexo = 'F';
        p2 Altura = 1.53;
        p2.Idade = 21;

            pessoas.Add(p2)

        Pessoa p3 = new Pessoa();
        p3.Nome = "Ronaldo";
        p3.Sexo = 'M';
        p3 Altura = 1.63;
        p3.Idade = 15;

            pessoas.Add(p3)

            List<Pessoa> menoresIdade = new List<Pessoa>();

            foreach (pessoa p in pessoas)
          {
            if (p.Idade < 18)
            {
            menoresIdade.Add(p);
            }
          }
         pessoas.Where(c=> c.Altura > 2 && c.Nome.ToUpper().StartsWith("E"));

         List<Pessoa> pessoasOrdendasPorAltura
         pessoas.OrderByDescending(p ==> p.Altura).ThenBy (c=> c.Idade).ToList();

         pessoas.Where(pes => pes.Idade < 18 )
        
        //delegate
        //pessoas.Where(PessoasQueNaoPodemSerPresas)
        //Lambda = Where/OrderBy/FirstOrDefault
    
    }

}        





















        //{
        //    //HashSet<int> numeros = new List<int>();
        //    List<int> numeros = new List<int>();
        //    Random rdm = new Random();

        //    //HashSet<int> dados = new HashSet<int>();
        //    //dados.Add(30);
        //    //dados.Add(30);


        //    for (int i = 0; i < 10; i++)
        //    {
        //        //Gera um número aleatório de 0 a 100
        //        int valorGeradoAleatoriamente = rdm.Next(100);

        //            //Verifica se a lista não contêm este número gerado
        //            if (!numeros.Contains(valorGeradoAleatoriamente))
        //        {
        //            //Adiciona o número gerado pelo random (que´não é repetido)
        //            numeros.Add(valorGeradoAleatoriamente);
        //        }

        //            else
        //        {
        //            i--;
        //        }
        //    }

        //    Console.ReadLine();
        //}


        //        {
        //            int i = 10;
        //            double j = 20.5;
        //            Amigos a = new Amigos();
        //            a.Nome = "Felipe";
        //            a.TempoAmizade = 15;
        //            Casar(a);
        //            Console.WriteLine(a.Nome); 

        //        }

        //        {
        //            int ii = 30;
        //            Hebeficar(out ii);
        //            Console.WriteLine(ii);
        //            int resultadoConversao = 0;
        //            int.TryParse("145", out resultadoConversao); //TryParse faz conversão númerica
        //        }

        //    /// b=a
        //    /// neste caso, "b" aponta para a mesma área
        //    /// de memoria que "a", ou seja
        //    /// alterar o vaor de "b" dentro deste metodo, afetara a instancia de "a" no metodo Main

        //        static void Casar(amigos b)

        //            b.Nome += "Bernart";


        //        static void Hebeficar( out int idade)
        //        {
        //            //idade = 30
        //            idade = 16000;
        //        }
    }
}
