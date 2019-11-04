using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioRegistroImoveisCore.Model
{
    public class Proprietario
    {
        [Key]
        public int Id { get; set; }

        [CustomValidator]
        public string Nome { get; set; } = String.Empty;

        [CustomValidator]
        public DateTime DataDeNascimento { get; set; } = DateTime.MinValue;

        [EmailAddress]
        public string Email { get; set; } = String.Empty;
    }
}
