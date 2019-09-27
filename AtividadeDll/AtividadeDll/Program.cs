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
            documentsAutoGenerate.CriarPastaMeusDocumentos("Estefani");
            documentsAutoGenerate.DeletarPastaMeusDocumentos("Estefani", true);
            documentsAutoGenerate.ObterPastasDiretorioMeuDocumentos().ForEach(x => Console.WriteLine(x)); 

        }
    }
}
