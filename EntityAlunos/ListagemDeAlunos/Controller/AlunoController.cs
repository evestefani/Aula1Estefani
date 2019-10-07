using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeAlunos.Model;

namespace ListagemDeAlunos.Controller
{
     public class AlunoController
    {
        EntityAlunosContextDB contextDB = new EntityAlunosContextDB();
        static AlunoController aluno = new AlunoController();

        public IQueryable<Aluno> GetAlunos() 
        {
            return contextDB.Alunos;
     
        }

        /// <summary>
        /// Metódo para adicionar Aluno no banco de dados
        /// </summary>
        /// <param name="item">Item Aluno</param>
        public void AddAluno(Aluno item)
        {
            contextDB. Alunos.Add(item); 

            contextDB.SaveChanges(); 
        }

            public void MostraMenuSistema()

        {
            var menuEscolhido = int.MinValue;

            while (menuEscolhido != 0)

            {
                Console.WriteLine();
                Console.WriteLine("<Menu sistema alunos>");
                Console.WriteLine();
                Console.WriteLine("1 - Cadastrar aluno");
                Console.WriteLine("2 - Mostrar lista de alunos");

                menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());


                switch (menuEscolhido)

                {
                    case 1:
                        AdicionarAluno();
                        break;
                    case 2:
                        ListarAlunos();
                        break;
                }
                MostraMenuSistema();
            }
        }

        private static void AdicionarAluno()
        {
            Console.WriteLine();
            Console.WriteLine("Nome do aluno: ");

            var nomeDoAluno = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Idade do aluno: ");

            var IdadeDoAluno = int.Parse(Console.ReadLine());

            aluno.AddAluno(
            new Aluno()
            {
                Nome = nomeDoAluno,
                Idade = IdadeDoAluno
            });

 
        }

            private static void ListarAlunos()
            {

               Console.WriteLine();
               aluno.GetAlunos().ToList<Aluno>().ForEach(item => Console.WriteLine($"ID: {item.Id}, Nome do Aluno: {item.Nome}, Idade: {item.Idade} anos"));

               Console.ReadKey();
            }


     }
}
