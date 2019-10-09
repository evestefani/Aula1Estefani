using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    /// <summary>
    /// Nossa Class que contem as informações que nossos livros vão apresentar
    /// </summary>
    public class Livro
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Nome { get; set; }

        public bool Ativo { get; set; } = true;

        public int UsuarioCriacao { get; set; } = 0;

        public int UsuarioAlteracao { get; set; } = 0;

        public DateTime DataCriacao { get; set; } = DateTime.Now;

        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}
