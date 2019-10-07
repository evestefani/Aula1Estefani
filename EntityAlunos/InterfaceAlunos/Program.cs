using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeAlunos.Controller;
using ListagemDeAlunos.Model;

namespace InterfaceAlunos
{
    class Program
    {
        static AlunoController aluno = new AlunoController();

        static void Main(string[] args)
        {

            aluno.MostraMenuSistema();

            Console.ReadKey();
        }

        

    }
}
