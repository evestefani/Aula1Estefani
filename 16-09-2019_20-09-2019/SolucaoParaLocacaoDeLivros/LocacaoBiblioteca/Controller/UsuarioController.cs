
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Model;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que contêm os metódos de usuários do sistema
    /// </summary>
    public class UsuarioController
    {

        LocacaoContext locacaoContext = new LocacaoContext();
        
        

        /// <summary>
        /// Metódo que realiza o login dentro do nosso sistema e para realizar o login padrão use:
        /// - Login: Admin
        /// - Senha: Admin
        /// </summary>
        /// <param name="Usuario">Passamos um objeto de nome Usuário como paramêtro</param>
        /// <returns>Retorna verdadeiro quando existir o usúario com este login e senha</returns>
        public UsuarioController()
        {
            var defaultUser = locacaoContext.Usuarios.FirstOrDefault(x => x.Login == "admin" && x.Senha == "admin" && x.Ativo == true);

            if (defaultUser == null)
                locacaoContext.Usuarios.Add(new Usuario()
                {
                    Login = "admin",
                    Senha = "admin"
                });

            locacaoContext.SaveChanges();
        }

        public IQueryable<Usuario> GetUsuarios()
        {
            return locacaoContext.Usuarios.Where(x => x.Ativo == true);
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

            locacaoContext.Usuarios.Add(item);

            locacaoContext.SaveChanges();

            return true;

        }


        /// <summary>
        /// Metodo que realiza o login dentro do nosso sistema
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool LoginSistema(Usuario usuario)

        {
            bool login = GetUsuarios().ToList().Exists(x => x.Login == usuario.Login && x.Senha == usuario.Senha);
            return login;
        }


        /// <summary>
        /// Metodo que atualiza o nosso usuario em nossa lista já "instanciada" criada dentro do construtor
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AtualizarUsuario(Usuario item)
        {

            var usuario = locacaoContext.Usuarios.FirstOrDefault(x => x.Id == item.Id);

            if (usuario == null)
                return false;
            else
            {
                item.DataAlteracao = DateTime.Now;
            }

            locacaoContext.SaveChanges();

            return true;
        }


        /// <summary>
        /// Metodo que retorna nossa lista interna de usuarios
        /// </summary>
        /// <returns>Lista contendo os usuarios ativos</returns>
        public List<Usuario> RetornaListaDeUsuarios()
        {
            //Retorna agora somente a lista de usuarios ativos com a expressao where
            return locacaoContext.Usuarios.Where(x => x.Ativo).ToList<Usuario>();
        }


        /// <summary>
        /// Metódo que desativa um registro de usuario cadastrado em nossa lista  
        /// </summary>
        /// <param name="identificadoID">Parametro que identifica o usuario que será desativado</param>
        public void RemoverUsuarioPorID(int identificadoID)
        {
      
            var usuario = locacaoContext.Usuarios.FirstOrDefault(x => x.Id == identificadoID);
            if (usuario != null)
                usuario.Ativo = false;
        }

    }
}   


