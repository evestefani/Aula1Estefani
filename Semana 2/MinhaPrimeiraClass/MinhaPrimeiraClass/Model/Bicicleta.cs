using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraClass.Model
{
    class Bicicleta //nossas classes são espelhos da tabela de banco de dados
    {
        public string Marca { get; set; }
        //get ele vai mostrar para a gente uma informação e o set a gente dá uma informação para ele
        public int Pneus { get; } = 2;

    }
}
