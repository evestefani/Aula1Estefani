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
        //private LocacaoContext contextDB = new LocacaoContext();//

        public LivroContextDB GetLivro = new LivroContextDB(); 

        /// <summary>
        /// Metodo construtor que prepara o terreno para já iniciar com livros pré cadastrados
        /// </summary>
        public LivroController()

        {

        }

        public IQueryable<Livro> GetLivros()
        {
            return GetLivro.Livros.Where(x => x.Ativo == true);
        }

        /// <summary>
        /// Metodo que adiciona o livro em nossa lista já "instanciada" criada dentro do construtor
        /// </summary>
        /// <param name="item">Informações do livro que vamos adicionar</param>
        public bool AdicionarLivro(Livro item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome))
                return false;

            GetLivro.Livros.Add(item); 

            GetLivro.SaveChanges(); 

            return true; 

        }


        /// <summary>
        /// Metodo que atualiza o nosso livro em nossa lista já "instanciada" criada dentro do construtor
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AtualizarLivro(Livro item)
        {
            
            var livro = GetLivro.Livros.FirstOrDefault(x => x.Id == item.Id);

    
            if (livro == null) 
                return false; 
            else
            {
                item.DataAlteracao = DateTime.Now; 

            }

            GetLivro.SaveChanges();

            return true; 
        }
    

        /// <summary>
        /// Metódo que desativa um registro de livro pelo ID
        /// </summary>
        /// <param name="identificadoID">Parametro que identifica o livro que será desativado</param>
        public void RemoverLivroPorID(int identificadoID)
        {
            //FirstOrDefault retorna null em caso de não encontrar um registro
            var livro = GetLivro.Livros.FirstOrDefault(x => x.Id == identificadoID);
            //tratamento do valor quando ele não encontrar um livro com o id
            if (livro != null)
                livro.Ativo = false;
            GetLivro.SaveChanges();
        }


        /// <summary>
        /// Metodo que retorna nossa lista interna de livros
        /// </summary>
        /// <returns>Lista contendo os livros</returns>
        public List<Livro> RetornaListaDeLivros()
        {
            return GetLivro.Livros.Where(x => x.Ativo).ToList<Livro>();
        }
    }
}
