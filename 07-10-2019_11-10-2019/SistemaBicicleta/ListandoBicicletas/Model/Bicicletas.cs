using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandoBicicletas.Model
{
    public class Bicicletas : ControleUsuario
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        [Required]
        public string Modelo { get; set;}

        [MaxLength(50)]
        [Required]
        public string Marca { get; set;}

        [Required]
        public double Valor { get; set; }
    }
}
