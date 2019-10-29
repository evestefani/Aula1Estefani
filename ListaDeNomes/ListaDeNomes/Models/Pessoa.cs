using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ListaDeNomes.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

    }
}