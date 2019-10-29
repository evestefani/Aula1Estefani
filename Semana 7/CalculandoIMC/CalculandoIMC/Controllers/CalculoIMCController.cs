using CalculandoIMC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CalculandoIMC.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalculoIMCController : ApiController
    {
        List<ObjetoIMC> listaDeObjetos = new List<ObjetoIMC>()
        {
            new ObjetoIMC() {Nome ="Estefani"},
            new ObjetoIMC() {Nome ="Bruno"},
            new ObjetoIMC() {Nome ="Elia"}
        };

        public List<ObjetoIMC> Get()
        {
            return listaDeObjetos;
        }

        public string Get(double altura, double peso, string nome)
        {
       
            var imc = peso / (altura * altura);

            return $"Olá {nome} o seu IMC é de: {imc.ToString("N2")}";
        }


        public  List<ObjetoIMC> Post(ObjetoIMC values)
        {
            ObjetoIMC imcCalc = values;

            imcCalc.ImcValue = imcCalc.Peso / (imcCalc.Altura * imcCalc.Altura);

            listaDeObjetos.Add(imcCalc);

            return listaDeObjetos;
        }
    }     
}

