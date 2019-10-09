using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalagoCelulares.Model
{
    public class ControleUsuario
    {
        public bool Ativo { get; set; } = true; //Definimos o campo com o valor Default 'true' para os nossos registros

        public int UsuarioCriacao { get; set; } = 0; //Definimos '0' para o usuário criado pelo sistema sem usuário logado

        public int UsuarioAlteracao { get; set; } = 0; //Definimos para alteração do sistema quando não logado usuário '0'

        public DateTime DataCriacao { get; set; } = DateTime.Now;

        public DateTime DataAlteracao { get; set; } = DateTime.Now;

    }
}
