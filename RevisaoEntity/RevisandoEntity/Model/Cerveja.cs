using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Model
{
    //Inicialemente sempre devemos deixar a nossa class public
    public class Cerveja
    {
        [Key] //Chave primária, auto incrementada pelo [ctrl + .]
        public int Id { get; set; }

        [StringLength(50)] //() significa que é um paramêtro (no paramêtro você deve definir uma regra que o seu metódo irá utilizar)
                           //E definimos a quantidade maxima de caracteres que iremos permitir em nosso campo Nome
        [Required] //Identifica que esse campo é obrigatório
        public string Nome { get; set; }

        [StringLength(30)]
        public string Tipo { get; set; }

        public double Teor { get; set; }

    }
}
