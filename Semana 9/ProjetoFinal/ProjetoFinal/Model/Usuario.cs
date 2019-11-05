using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Model
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [CustomValidator]
        public string Nome { get; set; } = String.Empty;

        [CustomValidator]
        public string Login { get; set; } = String.Empty;

        [CustomValidator]
        public string Senha { get; set; } = String.Empty;

        [EmailAddress]
        public string Email { get; set; } = String.Empty;
    }
}
