using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalagoCelulares.Model
{
    public class Usuario : ControleUsuario //Os dois pontos ':' sempre fara com que a tabela atual herde informações de outra tabela
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }

        [MaxLength(30)]
        [Required] // Obriga o usuário a passar a informação 
        public string Login { get; set; }

        [MaxLength(30)]
        [Required]
        public string Senha { get; set; }

    }
}
