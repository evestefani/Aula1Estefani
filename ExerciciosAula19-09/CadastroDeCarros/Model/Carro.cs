using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeCarros.Model
{
    class Carro
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Ano { get; set; }

        public double Valor { get; set; }

        public override string ToString()
        {
            return " A marca " + Marca + " do " + Modelo + " e ano " + Ano + " custa " + Valor + " ! ";
        }
    }
}
