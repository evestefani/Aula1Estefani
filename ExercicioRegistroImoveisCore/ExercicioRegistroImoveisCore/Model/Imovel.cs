using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioRegistroImoveisCore.Model
{
    public class Imovel
    {
        [Key]
        public int Id { get; set; }

        public int ProprietarioId { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string Complemento { get; set; }

        public string Municipio { get; set; }

        public string Cep { get; set; }

        public string UF { get; set; }
    }
}
