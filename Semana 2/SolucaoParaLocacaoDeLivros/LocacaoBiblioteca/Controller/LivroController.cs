using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Model;

namespace LocacaoBiblioteca.Controller

{   /// <summary>
    /// Classe que contêm os metódos de livros do sistema
    /// </summary>
    public class LivroController
    {

        LocacaoContext locacaoContext = new LocacaoContext();

        /// <summary>
        /// Metodo construtor que prepara o terreno para já iniciar com livros pré cadastrados
        /// </summary>
        public LivroController()

        {

        }

        public IQueryable<Livro> GetLivros()
        {
            return locacaoContext.Livros.Where(x => x.Ativo == true);
        }

        /// <summary>
        /// Metodo que adiciona o livro em nossa lista já "instanciada" criada dentro do construtor
        /// </summary>
        /// <param name="item">Informações do livro que vamos adicionar</param>
        public bool AdicionarLivro(Livro item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome))
            return false;

            locacaoContext.Livros.Add(item);

            locacaoContext.SaveChanges(); 

           return true;

        }
 

        /// <summary>
        /// Metodo que atualiza o nosso livro em nossa lista já "instanciada" criada dentro do construtor
        /// </summary>
        /// <param name="item">Livro que vamos estar atualizando dentro do nosso sistema</param>
        /// <returns>Retorna verdadeiro para quando o mesmo atualizar o livro</returns>
        public bool AtualizarLivro(Livro item)
        {
            //Nosso banco de dados.ListadeLivrosdo nosso banco de dados.Reegra de busca do nosso livro
            var livro = locacaoContext.Livros.FirstOrDefault(x => x.Id == item.Id);

    
            if (livro == null) //Verificamos se o livro realmente existe para estarmos atualizando
          
            {
             
                item.DataAlteracao = DateTime.Now; //Colocamos a data de alteração do nosso registro
                locacaoContext.SaveChanges();
                return true;
            }
            //Só chegamos a este ponto quando ele não realizar o salvamento da alteração
            return false;

            
        }
    

        /// <summary>
        /// Metódo que desativa um registro de livro pelo ID
        /// </summary>
        /// <param name="identificadoID">Parametro que identifica o livro que será desativado</param>
        public void RemoverLivroPorID(int identificadoID)
        {
            //FirstOrDefault retorna null em caso de não encontrar um registro
            var livro = locacaoContext.Livros.FirstOrDefault(x => x.Id == identificadoID);
            //tratamento do valor quando ele não encontrar um livro com o id
            if (livro != null)
                livro.Ativo = false;
            locacaoContext.SaveChanges();
        }


        /// <summary>
        /// Metodo que retorna nossa lista interna de livros
        /// </summary>
        /// <returns>Lista contendo os livros</returns>
        public List<Livro> RetornaListaDeLivros()
        {
            return locacaoContext.Livros.Where(x => x.Ativo).ToList<Livro>();
        }
    }
}
