using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext
    {
        //propriedade que armazena o ID dos livros adicionados ao sistema
        public int IdContadorLivros { get; set; } = 1;

        //propriedade que armazena o ID dos usuários adicionados ao sistema
        public int IdContadorUsuarios { get; set; } = 1;

        /// <summary>
        /// metodo condutor que prepara nossa classe LocacaoContext
        /// </summary>
        public LocacaoContext()
        {
            //criamos uma lista de livros em memória, adicionando os livros
            ListaDeLivros = new List<Livro>();

            //adicionamos um livro
            ListaDeLivros.Add(new Livro()
            {
                //Adiciono o ID contador incrementando o mesmo com ele + 1 "++"
                Id = IdContadorLivros++,
                Nome = "Peter Pan",
                DataCriacao = DateTime.Now
            }); 

            //adicionamos um livro
            ListaDeLivros.Add(new Livro()
            {
                //Adiciono o ID contador incrementando o mesmo com ele + 1 "++"
                Id = IdContadorLivros++,
                Nome = "Alice",
                DataCriacao = DateTime.Now
            });

            //criamos uma lista de livros em memória, adicionando os usuários
            ListaDeUsuarios = new List<Usuario>();

            //adicionamos um usuario
            ListaDeUsuarios.Add(new Usuario()
            {
                //Adiciono o ID contador incrementando o mesmo com ele + 1 "++"
                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "admin",
                DataCriacao = DateTime.Now
            });
            //adicionamos um usuario
            ListaDeUsuarios.Add(new Usuario()
            {
                //Adiciono o ID contador incrementando o mesmo com ele + 1 "++"
                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "123",
                DataCriacao = DateTime.Now
            });
        }

        public List<Livro> ListaDeLivros { get; set; }

        public List<Usuario> ListaDeUsuarios { get; set; }

}   }

