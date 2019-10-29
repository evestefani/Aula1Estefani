using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDePessoa.Model
{
    class Pessoa
    {
        
        
        public string Nome { get; set; }

        public int Idade { get; set; }

        public char Sexo { get; set; }

        public double Altura { get; set; }

        public override string ToString()
        {
            return "Nome " + Nome + " possui " + Idade + " é do sexo " + Sexo + " e tem " + Altura + " cm de altura! ";
        }

    }

}
