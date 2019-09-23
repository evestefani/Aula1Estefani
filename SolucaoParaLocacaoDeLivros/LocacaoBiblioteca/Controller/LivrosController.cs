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
        //Criando privado para impedir o programador de adicionar um ID ou alterar fora da classe
        private int idCount = 0;

        /// <summary>
        /// Metodo construtor que prepara o terreno para já iniciar com livros pré cadastrados
        /// </summary>
        public LivrosController()

        {
            //criamos uma lista de livros em memória
            ListaDeLivros = new List<Livro>();

            ////Adicionamos os livros 
            //Livros.Add(new Livro()
            //{   //Informo apenas o nome do livro para adicionar

            //Adiciono o Id contador incrementando o mesmo com ele + 1 "++"
            //    Id = idCount++,
            //    Nome = "Meu primeiro Livro"
            //});
            //Livros.Add(new Livro()
            //{
            //    Id = idCount++,
            //    Nome = "Meu segundo Livro"
            //});
    }

        /// <summary>
        /// Aqui crio uma propriedade para acessar o a lista de livros disponiveis no sistema
        /// </summary>
        private List<Livro> ListaDeLivros { get; set; }


        //------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Metodo que adiciona o livro em nossa lista já "instanciada" criada dentro do construtor
        /// </summary>
        /// <param name="parametroLivro">Informações do livro que vamos adicionar</param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            //Adicionamos o livro em nossa lista.
            ListaDeLivros.Add(parametroLivro);
            parametroLivro.DataCriacao = DateTime.Now;
            parametroLivro.Id = idCount;
            idCount++;
        }

        /// <summary>
        /// Metodo que retorna nossa lista interna de livros
        /// </summary>
        /// <returns>Lista contendo os livros</returns>
        public List<Livro> RetornaListaDeLivros()
        {
            return ListaDeLivros;
        }

    }
}
