using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Model;

namespace LocacaoBiblioteca.Controller
{    /// <summary>
     /// Classe que contêm os metódos de livros do sistema
     /// </summary>
    public class LivrosController
    {       
        
        /// <summary>
             /// Metodo construtor que prepara o terreo para já iniciar com livros pré cadastrados
             /// </summary>
        public LivrosController()


        {   //criamos uma lista de livros em memoria
            Livros = new List<Livro>();
            //Adicionamos os livros 
            Livros.Add(new Livro()
            {   //Informo apenas o nome do livro para adicionar
                Nome = "Meu primeiro Livro"
            });
            Livros.Add(new Livro()
            {
                Nome = "Meu segundo Livro"
            });
        }
        //Aqui crio uma propriedade para acessar o a lista de livros disponiveis no sistema
        public List<Livro> Livros { get; set; }
    }
}
