using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;
using System.Threading;


namespace InterfaceBiblioteca //Sistema - Regra de negócio
{
    class Program
    {
        //Instanciamos "Crregamos para a memoria nosso controlador dos livros
        static LivrosController livros = new LivrosController();
        //Instanciamos "Crregamos para a memoria nosso controlador dos usuarios
        static UsuarioController usuarios = new UsuarioController();

        static void Main(string[] args)
        {
            Console.WriteLine(" -------*SISTEMA DE LOCAÇÃO DE LIVROS 1.0*--------");
            Console.WriteLine();
            //Aqui realizamos a tela de login do nosso sistema
            while (!RealizaLoginSistema())
                Console.WriteLine("LOGIN e SENHA inválidos!");

            //Realizamos a chamada "invok" do nosso menu do sistema em um metodo
            MostraMenuSistema();

        }



        /// <summary>
        /// Mostra no console o menu disponível do sistema
        /// </summary>
        private static void MostraMenuSistema()

        {   //Iniciamos nossa variavel com o menor valor de int possivel
            var menuEscolhido = int.MinValue;
            //Aqui definimos se for diferente de 0 mantemos o sistema aberto se não finalizamos
            while (menuEscolhido != 0)

            {
                Console.Clear();
                Console.WriteLine(" -------*SISTEMA DE LOCAÇÃO DE LIVROS 1.0*--------");
                Console.WriteLine();
                //Mostra as opções do menu dentro do nosso sistema
                Console.WriteLine("<Menu sistema>");
                Console.WriteLine("1 - Listar usúarios");
                Console.WriteLine("2 - Listar Livros");
                Console.WriteLine("3 - Cadastrar Livro");
                Console.WriteLine("4 - Troca de usuário");
                Console.WriteLine("0 - Sair");

                ///Aqui vamos pegar o número digitado
                menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());

                ///executar próxima função
                switch (menuEscolhido)

                {  //Realiza a chamada dos menus
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo...");
                        Thread.Sleep(1700);
                        Environment.Exit(0);

                        break;
                    case 1:
                        MostrarUsuarios();
                        break;
                    case 2:
                        MostrarLivros();
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        while (!RealizaLoginSistema())
                            Console.WriteLine("LOGIN e SENHA inválidos!");
                            Console.Clear();
                        break;
                }
                MostraMenuSistema();
            }
        }
        /// <summary>
        /// Metodo que mostra os livros já cadastrados em nossa lista
        /// </summary>
        private static void MostrarLivros()
        {
            //Para cada livro cadastrado temos a demonstração no console por esta parte
            livros.Livros.ForEach(item => Console.WriteLine($"Nome do livro: {item.Nome}"));

            Console.ReadKey();
        }

        /// <summary>
        /// Metodo para mostrar a lista de usuário já cadastrados no sistema
        /// </summary>
        private static void MostrarUsuarios()
        {
            //Aqui andamos pela lista de usuários e mostramos ela no console
            usuarios.Usuario.ForEach(item => Console.WriteLine($"Nome do usuário: {item.Login}"));
            Console.ReadKey();

        }




        /// <summary>
        /// Metódo que realiza os procedimentos completos de login dentro do sistema como solicitação de login e senha pelo
        /// console assim como as respectivas validações que o mesmo precisa para entrar no sistema
        /// </summary>
        /// <returns>Retorna verdadeiro quando login e senha informados estiverem corretos</returns>
        private static bool RealizaLoginSistema()
        {
        
            //Informamos o que é preciso para entrar no sistema
            Console.WriteLine("Informe seu LOGIN e SENHA para acessar o sistema: ");
            //Informamos no console que precisamos do Login do usuario
            Console.WriteLine("Login: ");
            //Solicitamos o login
            var loginDoUsuario = Console.ReadLine();
            //Informamos no console que precisa da senha
            Console.WriteLine("Senha: ");
            //Solicitamos a senha do usuario
            var senhaDoUsuario = Console.ReadLine();

            //aqui carregamos em memoria nosso controlador de usuarios 
            UsuarioController usuarioController = new UsuarioController();

          
            Usuario usuario = new Usuario();
            usuario.Login = loginDoUsuario;
            usuario.Senha = senhaDoUsuario;

            //Validamos o login de maneira duvidosa
            return usuarioController.LoginSistema(usuario);


        }


    }
}
