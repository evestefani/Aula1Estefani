using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoBicicletas.Model;
using ListandoBicicletas.Controller;
using System.Threading;
using System.IO;

namespace InterfaceBicicleta
{
    class Program
    {
        static BicicletasController Bicicletas = new BicicletasController();
        
        static void Main(string[] args)
        {
      
            var opcao = int.MinValue;


            while (opcao != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Escolha um menu:");
                Console.WriteLine("1 - Inserir bicicleta");
                Console.WriteLine("2 - Atualizar bicicleta");
                Console.WriteLine("3 - Remover bicicleta");
                Console.WriteLine("4 - Listar bicicleta");
                Console.WriteLine("5 - Relatório de bicicletas");
                Console.WriteLine("0 - Sair\n");

     
                opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                        InserirBicicleta();
                        break;
                    case 2:
                        AtualizarBicicleta();
                        break;
                    case 3:
                        RemoverBicicleta();
                        break;
                    case 4:
                        ListarBicicleta();
                        break;
                    case 5:
                        RelatorioBicicleta();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo do sistema...");
                        Thread.Sleep(1700);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;

                }


                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu inicial!");


                Console.ReadKey(true);
                Console.Clear();
            }
        }

        /// <summary>
        /// Metódo para inserir uma bicileta no nosso sistema
        /// </summary>
        private static void InserirBicicleta()

        {

            Console.WriteLine("\n--- Insira a bicicleta ---\n");
            Console.WriteLine("\nInforme o modelo da bicicleta:");


            var marca = Console.ReadLine();

            Console.WriteLine("\nInforme a marca do modelo:");


            var modelo = Console.ReadLine();

            Console.WriteLine("\nInforme o valor da bicicleta:");


            var preco = double.Parse(Console.ReadLine());


            //Criamos o resultado para identificar sucesso ou erro, inserimos nossa controller pelo nome dela, inserimos um novo celular
            var resultado = Bicicletas.InserirBicicletas(new Bicicletas()
            {
                Marca = marca,
                Modelo = modelo,
                Valor = preco
            });

            //Verificamos se o resultado é verdadeiro ou falso, caso verdade 'sucesso', caso falso 'erro'
            if (resultado)

                Console.WriteLine("\nBicicleta cadastrada com sucesso!\n");
            else
                Console.WriteLine("\nErro ao cadastrar!");

        }


        /// <summary>
        /// Metódo para atualizar uma bibicleta que já está no nosso sistema
        /// </summary>
        private static void AtualizarBicicleta()

        {
            Console.WriteLine("\n--- Atualizar bicicleta ---");
            Console.WriteLine();

            ListarBicicleta();


            Console.WriteLine();
            Console.WriteLine("Informe o Id para alteração de registro");

            var bike = int.Parse(Console.ReadLine());

            var atualizarbike = Bicicletas.GetBicicletas().FirstOrDefault(x => x.ID == bike);

  
            if (atualizarbike == null)
                Console.WriteLine("Id informado inválido!");

            Console.WriteLine("\nInforme o modelo da bicicleta:");
       
            atualizarbike.Modelo = Console.ReadLine();

            Console.WriteLine("\nInforme a marca do modelo:");

            atualizarbike.Marca = Console.ReadLine();

            Console.WriteLine("\nInforme o valor da bicicleta:");

            atualizarbike.Valor = double.Parse(Console.ReadLine());


            var resultado = Bicicletas.AtualizarBicicleta(atualizarbike);

            if (resultado)
                Console.WriteLine("\nBicicleta atualizada com sucesso!\n");
            else
                Console.WriteLine("\nErro ao atualizar a bicicleta!");

        }


        /// <summary>
        /// Metódo para rmover uma bicicleta no nosso sistema
        /// </summary>
        private static void RemoverBicicleta()

        {
            Console.WriteLine("\n--- Remover bicicleta ---");
            Console.WriteLine();

            ListarBicicleta();

         
            Console.WriteLine();
            Console.WriteLine("Informe o Id para alteração de registro");

            //Obtemos o Id informado
            var removerbike = int.Parse(Console.ReadLine());


            var resultado = Bicicletas.RemoverBicicleta(removerbike);

            if (resultado) 
                Console.WriteLine("\nBicicleta removida com sucesso!\n");
            else
                Console.WriteLine("\nErro ao remover a bicicleta!");
        }


        /// <summary>
        /// Metódo para listar as bicicletas já cadastradas
        /// </summary>
        private static void ListarBicicleta()
        {
            Console.WriteLine("\n--- Listar bicicletas ---");
            Console.WriteLine();

           
         Bicicletas.GetBicicletas().ToList<Bicicletas>().ForEach(x => Console.WriteLine($"Id: {x.ID} Marca: {x.Marca} Modelo: {x.Modelo} Preço: {x.Valor.ToString("C")}"));


        }

        private static void RelatorioBicicleta() //SUPER BONUS
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Aperte 1 para exportar e 2 para exibir");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                sb.AppendLine("\n--- Relatório ordenado por valor ---");

                Bicicletas.GetBicicletas().OrderByDescending(x => x.Valor).ToList().ForEach(x => sb.AppendLine($"Id: {x.ID} Marca: {x.Marca} Modelo: {x.Modelo} Preço: {x.Valor.ToString("C")}"));

                sb.AppendLine("\n--- Valor total ---\n");
                sb.AppendLine(Bicicletas.GetBicicletas().Sum(x => x.Valor).ToString());

                File.WriteAllText(@"C:\Users\900081\Desktop\Exportado\dados.txt", sb.ToString());

                Console.WriteLine("Exportado com sucesso");
            }
            else
            {
                Console.WriteLine("\n--- Relatório ordenado por valor ---");

                Bicicletas.GetBicicletas().OrderByDescending(x => x.Valor).ToList().ForEach(x => Console.WriteLine ($"Id: {x.ID} Marca: {x.Marca} Modelo: {x.Modelo} Preço: {x.Valor.ToString("C")}"));

                Console.WriteLine("\n--- Valor total ---\n");
                Console.WriteLine(Bicicletas.GetBicicletas().Sum(x => x.Valor));
            }

            
            Console.ReadKey();
        }

    }
}
