using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoPessoas2.Model;

namespace ListandoPessoas2.Controller
{
    public class PessoaController
    {
        /// <summary>
        /// lista que contém as pessoas para realizar as atividades
        /// </summary>
        private List<Pessoa> ListaDePessoas { get; set; }

        /// <summary>
        /// metódo construtor ajuda a iniciar nossa classe para utilizarmos de maneira correta as informações internas com isso podemos iniciar nossa lista de pessoas sem depender do usuário ou programados na parte da interface
        /// </summary>
        public PessoaController()
        #region Lista de Pessoas
        {
            //iniciamos a lista de pessoas dentro do nosso metódo construtor
            ListaDePessoas = new List<Pessoa>();

            ListaDePessoas.Add(new Pessoa() { Id = 1, Nome = "Spears", DataNascimento = DateTime.Parse("07/11/2004"), Carteira = 846.96 });
            ListaDePessoas.Add(new Pessoa() { Id = 2, Nome = "Swanson", DataNascimento = DateTime.Parse("20/06/2003"), Carteira = 233.09 });
            ListaDePessoas.Add(new Pessoa() { Id = 3, Nome = "Gay", DataNascimento = DateTime.Parse("03/12/2001"), Carteira = 911.92 });
            ListaDePessoas.Add(new Pessoa() { Id = 4, Nome = "Gregory", DataNascimento = DateTime.Parse("02/01/2000"), Carteira = 469.01 });
            ListaDePessoas.Add(new Pessoa() { Id = 5, Nome = "Olson", DataNascimento = DateTime.Parse("18/07/2001"), Carteira = 261.90 });
            ListaDePessoas.Add(new Pessoa() { Id = 6, Nome = "Garza", DataNascimento = DateTime.Parse("01/04/2000"), Carteira = 360.41 });
            ListaDePessoas.Add(new Pessoa() { Id = 7, Nome = "Sweet", DataNascimento = DateTime.Parse("12/03/2003"), Carteira = 312.76 });
            ListaDePessoas.Add(new Pessoa() { Id = 8, Nome = "Cline", DataNascimento = DateTime.Parse("26/03/2002"), Carteira = 484.51 });
            ListaDePessoas.Add(new Pessoa() { Id = 9, Nome = "Oliver", DataNascimento = DateTime.Parse("05/07/2004"), Carteira = 513.76 });
            ListaDePessoas.Add(new Pessoa() { Id = 10, Nome = "Vang", DataNascimento = DateTime.Parse("10/07/2000"), Carteira = 271.05 });
            ListaDePessoas.Add(new Pessoa() { Id = 11, Nome = "Maddox", DataNascimento = DateTime.Parse("29/05/2004"), Carteira = 783.97 });
            ListaDePessoas.Add(new Pessoa() { Id = 12, Nome = "Garrett", DataNascimento = DateTime.Parse("03/06/2006"), Carteira = 154.11 });
            ListaDePessoas.Add(new Pessoa() { Id = 13, Nome = "Mcintosh", DataNascimento = DateTime.Parse("06/07/2006"), Carteira = 902.80 });
            ListaDePessoas.Add(new Pessoa() { Id = 14, Nome = "Yang", DataNascimento = DateTime.Parse("29/04/2005"), Carteira = 550.48 });
            ListaDePessoas.Add(new Pessoa() { Id = 15, Nome = "Hendricks", DataNascimento = DateTime.Parse("05/09/2003"), Carteira = 410.56 });
            ListaDePessoas.Add(new Pessoa() { Id = 16, Nome = "Cain", DataNascimento = DateTime.Parse("12/01/2002"), Carteira = 221.13 });
            ListaDePessoas.Add(new Pessoa() { Id = 17, Nome = "Blackburn", DataNascimento = DateTime.Parse("10/05/2000"), Carteira = 135.67 });
            ListaDePessoas.Add(new Pessoa() { Id = 18, Nome = "Howe", DataNascimento = DateTime.Parse("27/09/2005"), Carteira = 360.14 });
            ListaDePessoas.Add(new Pessoa() { Id = 19, Nome = "Pratt", DataNascimento = DateTime.Parse("18/09/2000"), Carteira = 991.83 });
            ListaDePessoas.Add(new Pessoa() { Id = 20, Nome = "Sherman", DataNascimento = DateTime.Parse("20/02/2003"), Carteira = 667.00 });
        }
        #endregion

        /// <summary>
        /// temos uma prorpriedade agora que retorna nossa lista com essa propriedade temos a lista completa e sem regras da lista de pessoas mas ao liberar somente o GET não damos acesso para alterar fora da classe a lista apenas vizualização
        /// </summary>
        public List<Pessoa> ListaDePessoasPublicas
        {
            get { return ListaDePessoas; }
        }

        /// <summary>
        /// metodo que retorna nossa lista de pessoas ordenada em ordem ascendente pelo nome de cada uma
        /// </summary>
        /// <returns>retornamos o valor já ordenado de nossa lista</returns>
        public List<Pessoa> GetPessoasOrdenadaAscendente()
        {
            //aqui temos nossa lista
            return ListaDePessoas
            //aqui ordenamos ela, IEnumerable é o novo tipo dela durante a conversão
            .OrderBy(x => x.Nome)
            //aqui voltamos o tipo para lista de pessoas
            .ToList<Pessoa>();
        }

        /// <summary>
        /// metodo que retorna nossa lista de pessoas ordenada em ordem descendente pelo nascimento de cada um
        /// </summary>
        /// <returns>retornamos o valor já ordenado de nossa lista</returns>
        public List<Pessoa> GetPessoasOrdenadaDescendenteNascimento()
        {
            //aqui temos nossa lista
            return ListaDePessoas
           //aqui ordenamos ela, IEnumerable é o novo tipo dela durante a conversão
           .OrderByDescending(x => x.DataNascimento)
           //aqui voltamos o tipo para lista de pessoas
           .ToList<Pessoa>();
        }

        /// <summary>
        /// metodo que retorna nossa lista de pessoas listando as pessoas que possuem determinado valor na carteira
        /// </summary>
        /// <param name="valor">valor informado para o filtro, caso não informado o parametro se torna 500</param>
        /// <returns>retorna a lista com o valor definido e ordenado</returns>
        public List<Pessoa> GetPessoasOrdenadaPorValorNaCarteira(double valor = 500) // --> em caso de não informarmos o valor ele fica 500 se ele não passar o valor informado pelo programados
        {
            //aqui temos nossa lista
            return ListaDePessoas
           //aqui ele irá achar todos os respectivos valores acima de 500,00
           .FindAll(x => x.Carteira > 500)
           //aqui ordenamos ela, IEnumerable é o novo tipo dela durante a conversão
           .OrderByDescending(x => x.Carteira)
           //aqui voltamos o tipo para lista de pessoas
           .ToList<Pessoa>();
        }

        /// <summary>
        /// metodo que retorna a lista de pessoas com idade maior que 'idade' informada, caso não informado um valor o padrão é 18
        /// </summary>
        ///  /// <param name="idade">parametro de idade</param>
        /// <returns>retorna a lista de pessoas pela idade informada</returns>
        public List<Pessoa> GetPessoasOrdenadaPorMaioresDeIdade(int idade = 18)
        {
            //aqui temos nossa lista
            return ListaDePessoas
           //aqui ele irá achar as pessoas por idade
           .FindAll(x => (DateTime.Now.Year - x.DataNascimento.Year) >= idade)
           //aqui ordenamos ela, IEnumerable é o novo tipo dela durante a conversão
           .OrderByDescending(x => x.DataNascimento)
           //aqui voltamos o tipo para lista de pessoas
           .ToList<Pessoa>();
        }

        /// <summary>
        /// metodo que retorna a lista de pessoas com idade menor que 'idade' informada, caso não informado um valor o padrão é 16
        /// </summary>
        ///  /// <param name="idade">parametro de idade</param>
        /// <returns>retorna a lista de pessoas pela idade informada</returns>
        public List<Pessoa> GetPessoasOrdenadaPorMenoresDeIdade(int idade = 16)
        {
            //aqui temos nossa lista
            return ListaDePessoas
           //aqui ele irá achar as pessoas por idade
           .FindAll(x => (DateTime.Now.Year - x.DataNascimento.Year) <= idade)
           //aqui ordenamos ela, IEnumerable é o novo tipo dela durante a conversão
           .OrderByDescending(x => x.DataNascimento)
           //aqui voltamos o tipo para lista de pessoas
           .ToList<Pessoa>();
        }
}   }             
        

