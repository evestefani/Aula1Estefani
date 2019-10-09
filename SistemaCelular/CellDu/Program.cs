using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalagoCelulares.Model;
using CatalagoCelulares.Controller;


namespace CellDu
{
    class Program
    {
        static CelularController celular = new CelularController();

        static void Main(string[] args)
        {
            //Definimos uma opção de um menu inicial
            var opcao = int.MinValue;

            //Definimos que enquanto for diferente de 0 ele continua em nosso loop
            while (opcao != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Escolha um menu:");
                Console.WriteLine("1 - Inserir celular");
                Console.WriteLine("2 - Atualizar celular");
                Console.WriteLine("3 - Remover celular");
                Console.WriteLine("4 - Listar celular");
                Console.WriteLine("0 - Sair\n");

                //Obtemos o menu escolhido pelo usuário
                opcao = int.Parse(Console.ReadLine());

                //Switch nos ajuda com a escolha da opção
                switch (opcao)
                {
                    case 1:
                        InserirCelular();
                        break;
                    case 2:
                        AtualizarCelular();
                        break;
                    case 3:
                        RemoverCelular();
                        break;
                    case 4:
                        ListarCelular();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;

                }

                
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu inicial!");

                //Colocamos true para informar que não deve aparecer na tela o valor pressionado
                Console.ReadKey(true);
                Console.Clear();
            }
        }


        /// <summary>
        /// Metódo para inserir um celular no nosso sistema
        /// </summary>
        public static void InserirCelular()

        {
            //Apresentamos a tela em que estamos
            Console.WriteLine("\n--- Insira o celular ---\n");
            Console.WriteLine("\nInforme a marca do celular:");

            //Obtemos a marca do usuário
            var marca = Console.ReadLine();

            Console.WriteLine("\nInforme o modelo do marca:");

            //Obtemos o modelo do celular
            var modelo = Console.ReadLine();

            Console.WriteLine("\nInforme o valor do celular:");

            //Obtemos o valor do celular
            var preco = double.Parse(Console.ReadLine());

            //Criamos o resultado para identificar sucesso ou erro, inserimos nossa controller pelo nome dela, inserimos um novo celular
            var resultado = celular.InserirCelular(new Celular()
            {
                Marca = marca,
                Modelo = modelo,
                Preco = preco
            });

            //Verificamos se o resultado é verdadeiro ou falso, caso verdade 'sucesso', caso falso 'erro'
            if (resultado) 
     
            Console.WriteLine("\nCelular cadastrado com sucesso!\n"); 
            else
                Console.WriteLine("\nErro ao cadastrar!");

        }


        /// <summary>
        /// Metódo para atualizar um celular que já está no nosso sistema
        /// </summary>
        public static void AtualizarCelular()

        {
            //Apresentamos a tela em que estamos
            Console.WriteLine("\n--- Atualizar celular ---");
            Console.WriteLine();

            ListarCelular();

            //Informamos ao usuário que ele precisa colocar o Id para realizar a alteração
            Console.WriteLine();
            Console.WriteLine("Informe o Id para alteração de registro");

            //Obtemos o Id informado
            var celulares = int.Parse(Console.ReadLine());

            //Obtemos do banco o item completo que vamos atualizar
            var aparelho = celular.GetCelulares().FirstOrDefault(x => x.Id == celulares);

            //Verificamos se o celular existe
            if (aparelho == null)
                Console.WriteLine("Id informado inválido!");

            Console.WriteLine("\nInforme a marca do celular:");
            //Obtemos a marca do usuário
            aparelho.Marca = Console.ReadLine();

            Console.WriteLine("\nInforme o modelo do marca:");

            //Obtemos o modelo do celular
            aparelho.Modelo = Console.ReadLine();

            Console.WriteLine("\nInforme o valor do celular:");

            //Obtemos o valor do celular
            aparelho.Preco = double.Parse(Console.ReadLine());


            var resultado = celular.AtualizarCelular(aparelho);

            if(resultado)
                Console.WriteLine("\nCelular atualizado com sucesso\n!");
            else
                Console.WriteLine("\nErro ao atualizar o celular!");
   

        }


        /// <summary>
        /// Metódo para rmover um celular no nosso sistema
        /// </summary>
        public static void RemoverCelular()

        {
            Console.WriteLine("\n--- Remover celular ---");
            Console.WriteLine();

            ListarCelular();

            //Informamos ao usuário que ele precisa colocar o Id para realizar a alteração
            Console.WriteLine();
            Console.WriteLine("Informe o Id para alteração de registro");

            //Obtemos o Id informado
            var celulares = int.Parse(Console.ReadLine());

            //Metódo que remove o celular do sistema
            var resultado = celular.RemoverCelular(celulares);

            if (resultado) //Apresentação dp resultado da operação
                Console.WriteLine("\nCelular removido com sucesso\n!");
            else
                Console.WriteLine("\nErro ao remover o celular!");
        }


        /// <summary>
        /// Metódo para listar os celualres já cadastrados
        /// </summary>
        public static void ListarCelular()
        {
            Console.WriteLine("\n--- Listar celular ---");
            Console.WriteLine();

            //Listamos aqui para identificar o item que vamos alterar 
            //celular.GetCelulares(): Obtemos a lista de celulares
            //ToList<Celular>(): Convertemos para uma lista em memória
            //ForEach: Laço de repetição para mostrar cada celular
            //(x => Console.WriteLine($"Id: {x.Id} Marca: {x.Marca} Modelo: {x.Modelo} Preço: {x.Preco}"): Mostramos no console o nosso celular
            celular.GetCelulares().ToList<Celular>().ForEach(x => Console.WriteLine($"Id: {x.Id} Marca: {x.Marca} Modelo: {x.Modelo} Preço: {x.Preco}"));


        }













    }
}











       

    

