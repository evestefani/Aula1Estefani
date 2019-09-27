using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllPastaWin;

namespace AtividadeDll
{
   class Program
    {
        static DocumentsAutoGenerate documentsAutoGenerate = new DocumentsAutoGenerate();
        
        static void Main(string[] args)
        {
            var menu = int.MinValue;
            while (menu != 0)
            {
                Console.Clear();
                Console.WriteLine("Sistema de pasta");
                Console.WriteLine("1 - Criar pasta em MeusDocumentos");
                Console.WriteLine("2 - Deletar pasta em MeusDocumentos");
                Console.WriteLine("3 - Lista MeusDocumentos");
                Console.WriteLine("4 - Bonus Sextouuuuu");
                Console.WriteLine("0 - Sair");

                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        //Informo pro usaurio que ele devera informar um nome para a pasta
                        Console.WriteLine("Informe o nome da pasta: ");
                        //Aqui obtemos o  nome que ele digitou para a pasta dele
                        var nomePasta = Console.ReadLine();
                        //Este metodo como mostra na documentação cria a pasta com base no nome que passamos
                        documentsAutoGenerate.CriarPastaMeusDocumentos(nomePasta);
                        break;
                    case 2:
                        Console.WriteLine("Informar o nome da pasta para ser deletada");
                        var nomePastaD = Console.ReadLine();
                        documentsAutoGenerate.DeletarPastaMeusDocumentos(nomePastaD,true);
                        break;
                    case 3:
                        //Obtemos a lista completa de pasta dentro dos meus documentos
                        documentsAutoGenerate.ObterPastasDiretorioMeuDocumentos()
                        //Apresenta esta lista para o usuario
                        .ForEach(x => Console.WriteLine(x));
                        break;
                    case 4:
                        new HoraDoShow().Birllllllllll();
                        break;
                }

                Console.ReadKey();
            }


        }
    }
}
