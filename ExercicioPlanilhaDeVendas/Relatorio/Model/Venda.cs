﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorio.Model
{
    public class Venda
    {
        public int ID { get; set; }
        public string Carro { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }


    }
}
