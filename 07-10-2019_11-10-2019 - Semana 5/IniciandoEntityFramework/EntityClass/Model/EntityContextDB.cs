using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    // O ':' significa que vai herdar informações pré prontas, 
    // sendo o DbContext classe pronta que contêm todos os processos de conexão com o banco de listagem de tabelas e seleção das informações
    public class EntityContextDB : DbContext
    {
       public DbSet // Palavra reservada para o Entity que indica que vamos definir um tabela do nosso bando de dados
                    // O DbSet é um criador de tabela
       <Pessoa> // Aqui definimos a nossa tabela 'pessoa', ou seja especificamos qual de nossas classes será uma referência de uma tabela do banco de dados
       ListaDePessoas { get; set; } // ListaDePessoas é somente um nome dao aleatoriamente, e então liberamos a nossa tabela para acesso

       
     
    }
}
