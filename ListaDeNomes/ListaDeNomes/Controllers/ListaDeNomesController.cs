using ListaDeNomes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ListaDeNomes.Controllers
{
    public class ListaDeNomesController : ApiController
    {

        List<Pessoa> Pessoas = new List<Pessoa>()
         
        {
            new Pessoa() {Nome="Estefani", Idade=31},
            new Pessoa() {Nome="Bruno", Idade=30},
            new Pessoa() {Nome="Elia", Idade=54},
            new Pessoa() {Nome="Camila", Idade=36},
            new Pessoa() {Nome="Maria", Idade=5},
            new Pessoa() {Nome="Lucas", Idade=3},
            new Pessoa() {Nome="João", Idade=40},
            new Pessoa() {Nome="Lou", Idade=1},
            new Pessoa() {Nome="Lucy", Idade=1},
            new Pessoa() {Nome="Maga", Idade=5}

         };

        public List<Pessoa> Get()
        {
            return Pessoas;   
        }

        public Pessoa Post(Pessoa item)
        {

            Pessoas.Add(item);

            return item;
        }
    }

}
