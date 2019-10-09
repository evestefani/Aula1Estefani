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
        private LocacaoContext contextDB = new LocacaoContext();
        public UsuarioContextDB GetUsuario = new UsuarioContextDB();
        

        /// <summary>
        /// Metódo que realiza o login dentro do nosso sistema e para realizar o login padrão use:
        /// - Login: Admin
        /// - Senha: Admin
        /// </summary>
        /// <param name="Usuario">Passamos um objeto de nome Usuário como paramêtro</param>
        /// <returns>Retorna verdadeiro quando existir o usúario com este login e senha</returns>
        public UsuarioController()
        {

        }


        /// <summary>
        /// Metodo usado para adicionar um novo usuario do sistema
        /// </summary>
        /// <param name="parametroUusario">Nono usuario que será adicionado a lista</param>
        public bool AdicionarUsuario(Usuario item)
        {
            if (string.IsNullOrWhiteSpace(item.Login))
                return false;

            if (string.IsNullOrWhiteSpace(item.Senha))
                return false;

            GetUsuario.Usuarios.Add(item);

            GetUsuario.SaveChanges();

            return true;

        }


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
        /// Metodo que atualiza o nosso usuario em nossa lista já "instanciada" criada dentro do construtor
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AtualizarUsuario(Usuario item)
        {

            var livro = GetUsuario.Usuarios.FirstOrDefault(x => x.Id == item.Id);

            if (livro == null)
                return false;
            else
            {
                item.DataAlteracao = DateTime.Now;
            }

            GetUsuario.SaveChanges();

            return true;
        }


        /// <summary>
        /// Metodo que retorna nossa lista interna de usuarios
        /// </summary>
        /// <returns>Lista contendo os usuarios ativos</returns>
        public List<Usuario> RetornaListaDeUsuarios()
        {
            //Retorna agora somente a lista de usuarios ativos com a expressao where
            return contextDB.ListaDeUsuarios.Where(x => x.Ativo).ToList<Usuario>();
        }


        /// <summary>
        /// Metódo que desativa um registro de usuario cadastrado em nossa lista  
        /// </summary>
        /// <param name="identificadoID">Parametro que identifica o usuario que será desativado</param>
        public void RemoverUsuarioPorID(int identificadoID)
        {
            //FirstOrDefault retorna null em caso de não encontrar um registro
            var usuario = contextDB.ListaDeUsuarios.FirstOrDefault(x => x.Id == identificadoID);
            //tratamento do valor quando ele não encontrar um livro com o id
            if (usuario != null)
                usuario.Ativo = false;
        }

    }
}   


