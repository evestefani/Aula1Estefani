using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;

namespace EntityClass.Controller
{
    public class PessoaController
    {
        // Realizo a minha conexão com o banco de dados 
        EntityContextDB contextDB = new EntityContextDB();

        public IQueryable<Pessoa> GetPessoas() // Aqui temos nossa primeira Interface com a classe IQueryable
                                               // essa classe contêm varias funcionalidades prontas para usar igual ao banco de dados, como os SELECTS 
                                               // Definimos o tipo que ira retornas <Pessoa>
                                               // Damos um nome ao metódo 'GetPessoas'
        {                 
            return contextDB.ListaDePessoas;
            // Retornamos a nossa lista de pessoas
        }

        /// <summary>
        /// Metódo para adicionar Pessoa no banco de dados
        /// </summary>
        /// <param name="item">Item Pessoa</param>
        public void AddPessoa(Pessoa item)
        {
            contextDB. // Nosso banco de dados
            ListaDePessoas. // Nossa tabela Pessoa
            Add(item); // Adicionamos o item

            contextDB.SaveChanges(); // Salvamos no banco de dados
        }
    }
}
