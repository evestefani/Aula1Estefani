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
    public class LivrosController
    {
        private LocacaoContext contextDB = new LocacaoContext();

        /// <summary>
        /// Metodo construtor que prepara o terreno para já iniciar com livros pré cadastrados
        /// </summary>
        public LivrosController()

        {

        }

        //------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Metodo que adiciona o livro em nossa lista já "instanciada" criada dentro do construtor
        /// </summary>
        /// <param name="parametroLivro">Informações do livro que vamos adicionar</param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            //Adicionamos o livro em nossa lista.
            parametroLivro.Id = contextDB.IdContadorLivros++;
            contextDB.ListaDeLivros.Add(parametroLivro);
            parametroLivro.DataCriacao = DateTime.Now;

        }

        /// <summary>
        /// Metodo que retorna nossa lista interna de livros
        /// </summary>
        /// <returns>Lista contendo os livros</returns>
        public List<Livro> RetornaListaDeLivros()
        {
            return contextDB.ListaDeLivros.Where(x => x.Ativo).ToList<Livro>();
        }

        /// <summary>
        /// Metódo que desativa um registro de livro pelo ID
        /// </summary>
        /// <param name="identificadoID">Parametro que identifica o livro que será desativado</param>
        public void RemoverLivroPorID(int identificadoID)
        {
            //FirstOrDefault retorna null em caso de não encontrar um registro
            var livro = contextDB.ListaDeLivros.FirstOrDefault(x => x.Id == identificadoID);
            //tratamento do valor quando ele não encontrar um livro com o id
            if (livro != null)
                livro.Ativo = false;
        }

    }
}
