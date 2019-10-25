using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CalculandoIMC.Controllers
{
  

    public class CalculoIMCController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]

        public string Get(double Altura, double Peso, string Nome)
        {
       
            var imc = Peso / (Altura * Altura);

            return $"Olá {Nome} o seu IMC é de:{imc}";
        }
    }     


}

