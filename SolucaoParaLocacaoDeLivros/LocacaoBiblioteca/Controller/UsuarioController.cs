using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que contêm os metódos de usuários do sistema
    /// </summary>
    public class UsuarioController
    {
        //Criando privado para impedir o programador de adicionar um ID ou alterar fora da classe
        private int IdCount = 0;

        /// <summary>
        /// Metódo que realiza o login dentro do nosso sistema e para realizar o login padrão use:
        /// - Login: Admin
        /// - Senha: Admin
        /// </summary>
        /// <param name="Usuario">Passamos um objeto de nome Usuário como paramêtro</param>
        /// <returns>Retorna verdadeiro quando existir o usúario com este login e senha</returns>
        public UsuarioController()
        {
            ListaDeUsuarios = new List<Usuario>();

            ListaDeUsuarios.Add(new Usuario()
            {
                //Adiciono o ID contador incrementando o mesmo com ele + 1 "++"
                Id = IdCount++,
                Login = "Admin",
                Senha = "Admin"
            });

        }

        /// <summary>
        /// Aqui crio uma propriedade para acessar o a lista de livros disponiveis no sistema
        /// </summary>
        private List<Usuario> ListaDeUsuarios { get; set; }

        /// <summary>
        /// Metodo que realiza o login dentro do nosso sistema
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool LoginSistema(Usuario usuario)

        {
            return RetornaListaDeUsuarios().Exists(x => x.Login == usuario.Login && x.Senha == usuario.Senha);
        }

        /// <summary>
        /// Metodo usado para adicionar um novo usuario do sistema
        /// </summary>
        /// <param name="parametroUusario">Nono usuario que será adicionado a lista</param>
        public void AdicionarUsuario(Usuario parametroUsuario)
        {
            parametroUsuario.Id = IdCount++;

            //Adiciono o meu usuario a minha lista
            ListaDeUsuarios.Add(parametroUsuario);
            parametroUsuario.DataCriacao = DateTime.Now;
        }

        /// <summary>
        /// Metodo que retorna nossa lista interna de usuarios
        /// </summary>
        /// <returns>Lista contendo os usuarios ativos</returns>
        public List<Usuario> RetornaListaDeUsuarios()
        {
            //Retorna agora somente a lista de usuarios ativos com a expressao where
            return ListaDeUsuarios.Where(x => x.Ativo).ToList<Usuario>();
        }

        /// <summary>
        /// Metódo que desativa um registro de usuario cadastrado em nossa lista  
        /// </summary>
        /// <param name="identificadoID">Parametro que identifica o usuario que será desativado</param>
        public void RemoverUsuarioPorID(int identificadoID)
        {
            //Aqui usamos o metódo FirstOrDefaul para localizar nosso usuário dentro da lista, com isso conseguimos acessar as propriedades dele e desativar o registro
            ListaDeUsuarios.FirstOrDefault(x => x.Id == identificadoID).Ativo = false;
        }

    }
}   


