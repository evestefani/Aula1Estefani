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
        /// <summary>
        /// Metódo que realiza o login dentro do nosso sistema e para realizar o login padrão use:
        /// - Login: Admin
        /// - Senha: Admin
        /// </summary>
        /// <param name="Usuario">Passamos um objeto de nome Usuário como paramêtro</param>
        /// <returns>Retorna verdadeiro quando existir o usúario com este login e senha</returns>

        //bool: é um estado de pergunta, condições de responder sim e não, falso ou verdadeiro, etc...

        public UsuarioController()
        {
            Usuario = new List<Usuario>();

            Usuario.Add(new Usuario()
            {
                Login = "Admin",
                Senha = "Admin"
            });
            Usuario.Add(new Usuario()
            {
                Login = "Ste",
                Senha = "123"
            });
        }

        public List<Usuario> Usuario { get; set; }

        public bool LoginSistema(Usuario usuarios)

        {
            return Usuario.Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
        }

       
        
       
    }
}

//    Outro exemplo para o bool                                  || significa 'ou'
//    if (usuarios.Login == "Admin" && usuarios.Senha == "Admin" || usuarios.Login == "Ste" && usuarios.Senha == "123")
//        // && singnifica 'e'
//        return true;
//    else
//        return false;
//