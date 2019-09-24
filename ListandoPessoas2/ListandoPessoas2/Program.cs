using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoPessoas2.Controller;
using ListandoPessoas2.Model;
using System.Globalization;

namespace ListandoPessoas2
{
    class Program
    {
        static void Main(string[] args)
        {
            //aqui carregamos a nossa caixa de ferramentas de pessoas, podemos agora listar juntamente com as demais funcionalidades
            PessoaController pessoaController
            //nesta parte ao iniciar em memoria, iniciamos o construtor
            = new PessoaController();

            //aqui acessamos nossa lista de pessoas
            pessoaController.ListaDePessoasPublicas

            .ForEach(item => //usamos o ForEach do linq para percorrer a lista e criamos a variável "item" para receber o item da nossa lista
            //imprimimos a informação de cada item da nossa lista
            MostraInformacoes(item));

            MostraIdentificador("Lista ordenada pelo nome");

            pessoaController.GetPessoasOrdenadaAscendente().ForEach(item => MostraInformacoes(item));

            MostraIdentificador("Lista ordenada pelo nascimento");

            pessoaController.GetPessoasOrdenadaDescendenteNascimento().ForEach(item => MostraInformacoes(item));

            MostraIdentificador("Lista ordenada pelo valor da carteira");

            pessoaController.GetPessoasOrdenadaPorValorNaCarteira().ForEach(item => MostraInformacoes(item));

            MostraIdentificador("Lista maiores de 18 anos");

            pessoaController.GetPessoasOrdenadaPorMaioresDeIdade(18).ForEach(item => MostraInformacoes(item));

            MostraIdentificador("Lista menores de 16 anos");

            pessoaController.GetPessoasOrdenadaPorMenoresDeIdade(16).ForEach(item => MostraInformacoes(item));



            Console.ReadKey();

        }
        /// <summary>
        /// metodo que mostra no console formatado nosso objeto ´Pessoa'
        /// </summary>
        /// <param name="pessoa">objeto Pessoa que vamos apresentar</param>
        private static void MostraInformacoes(Pessoa pessoa)
        {
            //nosso template que apresenta as informações organizadamente
            //o format usa {0}, essa expressão é para colocar de acordo com a ordem informada dos parametros
            string template = "Id {0,-3} Nome {1,-10} Nascimento {2,10} Carteira {3,5}";
            //recebemos informações organizadamente com o string format
            string textoFormatado = 
            //string.Format é usado para formatar a string deixando nosso texto padrão e apresentável
            string.Format(
            //nosso primeiro parametro é o template que usamos
            template,
            //após informar o template temos um parametro, este metodo espera um array de parametros ou seja podemos passar muitos parametros nele
            pessoa.Id,pessoa.Nome,
            //formatamos a data de nascimento para apresentar a informação reduzida
            pessoa.DataNascimento.ToShortDateString(),
            //aqui apresentamos em valor monetário de acordo com as configurções local da máquina
            pessoa.Carteira.ToString("C"));

            Console.WriteLine(textoFormatado);

        }

        /// <summary>
        /// metodo para mostrar a informação inicial de cada listagem
        /// </summary>
        /// <param name="nomeAcao">identificador da listagem</param>
       private static void MostraIdentificador(string nomeAcao)
        {
            Console.WriteLine(string.Format("\n---- {0,20} ----\n", nomeAcao));
        }
    }
}
