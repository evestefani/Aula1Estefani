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
        //Instanciamos "Carregamos para a memoria nosso controlador dos livros
        static LivrosController livrosController = new LivrosController();

        //Instanciamos "Carregamos para a memoria nosso controlador dos usuarios
        static UsuarioController usuariosController = new UsuarioController();

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
                Console.WriteLine("1 - Cadastrar usuários");
                Console.WriteLine("2 - Listar usúarios");
                Console.WriteLine("3 - Troca de usuário");
                Console.WriteLine("4 - Cadastrar Livro");
                Console.WriteLine("5 - Listar Livros");
                Console.WriteLine("6 - Remover usuário");
                Console.WriteLine("0 - Sair");

                ///Aqui vamos pegar o número digitado
                menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());

                ///executar próxima função
                switch (menuEscolhido)

                {   //Realiza a chamada dos menus
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo...");
                        Thread.Sleep(1700);
                        Environment.Exit(0);
                        break;
                    case 1:
                        AdicionarUsuario(); //Metodo que adiciona um usuario ao nosso sistema
                        break;
                    case 2:
                        MostrarUsuarios(); //Metodo que lista os usuarios cadastrados no sistema
                        break;
                    case 3:
                        while (!RealizaLoginSistema())
                            Console.WriteLine("LOGIN e SENHA inválidos!");
                            Console.Clear();
                        break;
                    case 4:
                        AdicionarLivro(); //Metodo que adiciona um livro ao nosso sistema
                        break;
                    case 5:
                        MostrarLivros(); //Metodo que lista os livros cadastrados no sistema
                        break;
                    case 6:
                        RemoveUsuarioPeloID(); //Metodo que inicializa a tela para remover o usuario
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
            livrosController.RetornaListaDeLivros().ForEach(item => Console.WriteLine($"ID {item.Id}: Nome do livro: {item.Nome}, {item.DataCriacao}"));

            Console.ReadKey();
        }

        /// <summary>
        /// Metodo para mostrar a lista de usuário já cadastrados no sistema
        /// </summary>
        private static void MostrarUsuarios()
        {
            //Aqui andamos pela lista de usuários e mostramos ela no console
            usuariosController.RetornaListaDeUsuarios().ForEach(item => Console.WriteLine($"ID {item.Id}: Nome do usuário: {item.Login}, {item.DataCriacao}"));
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

          
            Usuario usuario = new Usuario();
            usuario.Login = loginDoUsuario;
            usuario.Senha = senhaDoUsuario;

            //Validamos o login de maneira duvidosa
            return usuariosController.LoginSistema(usuario);


        }

        /// <summary>
        /// Metódo que adiciona dentro da nossa lista um novo registro de livro
        /// </summary>
        private static void AdicionarLivro()
        {
            //Identificamos que o mesmo esta na parte de cadastro de livros do sistema
            Console.WriteLine("Cadastrar livro dentro do sistema: ");

            //Informamos que para dar continuidade ele deve informar o nome de um livro
            Console.WriteLine("Nome do livro cadastrado: ");

            //Obtemos esta informação do usuario
            var nomeDoLivro = Console.ReadLine();


            //"livrosController" livros controlle e nosso "objeto" em memoria
            //com isso temos disponível nele ferramentas que nos ajudam a realizar tarefas como adicionar um item a nossa lista de livros
            livrosController.AdicionarLivro(new Livro()
            {
                //Aqui "atribuinmos" o nome que demos ao livro na propriedade Nome do nosso livro com o sinal de apenas um "="
                // trmos atribuição, passagemd de valor
                Nome = nomeDoLivro
            });



            //Indico que finalizamos o processo de cadastro de livro, assim o usuario já sabe que o mesmo foi realizado e sem erros
            Console.WriteLine("Livro cadastrado com sucesso!");

            //Readkey apenas para que ele vizualize esta informação
            Console.ReadKey();
        }

        /// <summary>
        /// Metódo que adiciona dentro da nossa lista um novo registro de usuário
        /// </summary>
        private static void AdicionarUsuario()

        {
            //Identificamos que o mesmo esta na parte de cadastro de usuario do sistema
            Console.WriteLine("Cadastrar usuário dentro do sistema: ");

            //Informamos que para dar continuidade ele deve informar o nome do usuário
            Console.WriteLine("Informe um login: ");

            //Obtemos esta informação do usuario
            var nomeDoUsuario = Console.ReadLine();

            Console.WriteLine("Informe uma senha: ");
            var senhaDoUsuario = Console.ReadLine();

            ////"usuariosController" usuário controlle e nosso "objeto" em memoria
            ////com isso temos disponível nele ferramentas que nos ajudam a realizar tarefas como adicionar um item a nossa lista de usuários
            usuariosController.AdicionarUsuario(new Usuario()
            {
                //Aqui "atribuinmos" o nome que demos ao livro na propriedade Nome do nosso livro com o sinal de apenas um "="
                // trmos atribuição, passagemd de valor
                Login = nomeDoUsuario,
                Senha = senhaDoUsuario
            });


            //Indico que finalizamos o processo de cadastro de livro, assim o usuario já sabe que o mesmo foi realizado e sem erros
            Console.WriteLine("Usuário cadastrado com sucesso!");

            //Readkey apenas para que ele vizualize esta informação
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo que remove os usuarios disponiveis no sistema
        /// </summary>
        private static void RemoveUsuarioPeloID()
        {
            Console.WriteLine("Remover um usuário pelo ID do sistema");
            //Metódo que mostra os usuarios criados anteriormente, assim facilitando o usuario informar o ID correto a ser desativado
            MostrarUsuarios();

            Console.WriteLine("Informe o ID para desativar do sistema: ");
            var usuarioID = int.Parse(Console.ReadLine());

            //Aqui chamamos RemoverUsuaruoPorID da nossa classe que controla os usuarios do sistema
            usuariosController.RemoverUsuarioPorID(usuarioID);

            //Informamos que o usuario foi desativado com sucesso
            Console.WriteLine("Usuário destaivado com sucesso!");
            Console.ReadKey();

        }
            
        
    }
}
