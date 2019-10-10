using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandoFlores.Model
{
    public class Flores
    { 
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Nome { get; set; }

        [Required]
        public int Quantidade { get; set; } = 1;
    }
}
