using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalagoCelulares.Model;

namespace CatalagoCelulares.Controller
{
    public class CelularController
    {
        // Criar uma isntância nova da nossa context
        public CelularesContextDB contextDB = new CelularesContextDB();


        //------------------------------------------------------------------------------------------------------------------------------------------//

        // Metódo para Listagem

        /// <summary>
        /// Metódo que retorna nossa lista de celulares ativos apenas
        /// </summary>
        /// <returns>QueryList de celulares filtrado por ativo</returns>
        public IQueryable<Celular> GetCelulares()
        {
            return contextDB.Celulares.Where(x => x.Ativo == true);
        }


        //------------------------------------------------------------------------------------------------------------------------------------------//

        // Metódo para Atualização

        /// <summary>
        /// Metódo que atualiza um registro válido do nosso sistema
        /// </summary>
        /// <param name="item">Item que vamos atualizar</param>
        /// <returns>Retornamos verdadeiro caso o item exista</returns>
        public bool AtualizarCelular(Celular item)
        {
            //Definimos uma variavel = usamos o banco de dados.usamos nossa tabela de celulares.buscamos em nossa tabela o celular(regra para realizar a busca)
            var celular = contextDB.Celulares.FirstOrDefault(x => x.Id == item.Id);

            //Falamos que nosso celular da tabela vai ser igual ao nosso celular que estamos passando

            if (celular == null) //Verificamos se ele realmente encontrou um celular
                return false; //Caso não tenha encontrado retornamos como falso
            else
            {
                item.DataAlteracao = DateTime.Now; //Atualizamos a data da alteração do nosso celular
            }

            contextDB.SaveChanges(); //Salvamos essa informação no banco de dados

            return true; //Retornamos que ele foi atualizado
        }


        //------------------------------------------------------------------------------------------------------------------------------------------//

        // Metódo para Inserção

        /// <summary>
        /// Metódo que valida e insere os registros dentro do sistema
        /// </summary>
        /// <param name="item">Nosso novo celular</param>
        /// <returns>Retorna verdadeiro para um item válido</returns>
        public bool InserirCelular(Celular item)
        {
            //(Nosso tipo que contêm vários metódos prontos para string.Metódo que identifica espaços em branco ou apenas valor null(nosso campo que vamos validar))
            if (string.IsNullOrWhiteSpace(item.Marca))
                return false;

            if (string.IsNullOrWhiteSpace(item.Modelo))
                return false;

            
            if (item.Preco <= 0) //(Verificamos se o valor informado é maior que 0)
                return false; //Caso não, ele já retorna para fora do metódo

            contextDB.Celulares.Add(item); //Salvamos nosso item dentro da nossa tabela de memória
            contextDB.SaveChanges(); //Salvamos agora no banco de dados esta informação

            return true; //Retornamos verdadeiro para indicar sucesso na inserção do registro
        }


        //------------------------------------------------------------------------------------------------------------------------------------------//

        // Metódo para 'Remoção'

        /// <summary>
        /// Metódo utilizado para apenas desativar o item dentro do nosso sistema
        /// </summary>
        /// <param name="id">Id que vamos desativar</param>
        /// <returns>Retorna verdadeiro em caso de sucesso</returns>
        public bool RemoverCelular(int id)
        {
            //Nossa variavel = nossa base de dados.nossa tabela celular.buscamos o item para desativar(informamos a regra de busca por Id)
            var celular = contextDB.Celulares.FirstOrDefault(x => x.Id == id);

            if (celular == null) //Verificamos se este item existe 
                return false; //Caso não, ele sai do nosso metódo

            celular.Ativo = false; //Desativamos o item

            contextDB.SaveChanges(); //Salvamos em nosso banco de dados

            return true; //Retornamos verdadeiro

        }


    }
}
