using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeNomes.Model
{
    public class Nomes
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        [Required]
        public string Nome { get; set; }

    }
}
