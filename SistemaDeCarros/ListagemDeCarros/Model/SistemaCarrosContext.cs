using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListagemDeCarros.Model
{
    public class SistemaCarrosContext //metódo construtor
    {
        /// <summary>
        /// Nossa massa de dados interna
        /// </summary>
        private List<Carro> ListaDeCarros { get; set; }


        /// <summary>
        /// Construtor que prepara a nossa massa de dados
        /// </summary>
        public SistemaCarrosContext ()
        {
            ListaDeCarros = new List<Carro>();

            ListaDeCarros.Add(new Carro() {Id = 1, Marca = "Volvo", Modelo = "S90", Ano = 2019, Cv = 407 , Portas = 4});
            ListaDeCarros.Add(new Carro() {Id = 1, Marca = "Chevrolet", Modelo = "Onix", Ano = 2020, Cv = 116, Portas = 4});
            ListaDeCarros.Add(new Carro() {Id = 1, Marca = "Volkswagen", Modelo = "UP", Ano = 2020, Cv = 105, Portas = 4});
            ListaDeCarros.Add(new Carro() {Id = 1, Marca = "Volkswagen", Modelo = "Gol", Ano = 2017, Cv = 110, Portas = 2});
            ListaDeCarros.Add(new Carro() {Id = 1, Marca = "Renault", Modelo = "Sandero", Ano = 2014, Cv = 115, Portas = 4});
            ListaDeCarros.Add(new Carro() {Id = 1, Marca = "Ford", Modelo = "Ranger", Ano = 1998, Cv = 306, Portas = 4});
            ListaDeCarros.Add(new Carro() {Id = 1, Marca = "Honda", Modelo = "HRV", Ano = 2019, Cv = 405, Portas = 2});
            ListaDeCarros.Add(new Carro() {Id = 1, Marca = "Fiat", Modelo = "Uno", Ano = 2015, Cv = 105, Portas = 2});
            ListaDeCarros.Add(new Carro() {Id = 1, Marca = "Ford", Modelo = "Ka", Ano = 2018, Cv = 85, Portas = 2 });
            ListaDeCarros.Add(new Carro() {Id = 1, Marca = "Renault", Modelo = "Kwid", Ano = 2019, Cv = 90, Portas = 4});


        }

        /// <summary>
        /// Propriedade que contem a lista de carros sem nenhum tipo de filtro
        /// </summary>
        public List<Carro> ListaDeCarrosPublica { get { return ListaDeCarros; } }
    }
   
    
    
}
