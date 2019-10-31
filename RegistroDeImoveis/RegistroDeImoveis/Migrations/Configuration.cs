namespace RegistroDeImoveis.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using RegistroDeImoveis.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<RegistroDeImoveis.Models.RegistroDeImoveisContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RegistroDeImoveisContext context)
        {
            var listProprietarios = new List<Proprietario>() {
                new Proprietario(){
                    Nome = "Felipe",
                    DataDeNascimento = DateTime.Parse("03/08/1992"),
                    Email = "contato@usysweb.com.br"
                },
                new Proprietario()
                {
                    Nome = "Giomar",
                    DataDeNascimento = DateTime.Parse("24/01/1836"),
                    Email = "contato@pulsaopubmatico.org"
                }
            };

            listProprietarios.ForEach(s =>
                context.Proprietarios.AddOrUpdate(x => x.Nome, s)
            );

            context.SaveChanges();

            var listaImoveis = new List<Imovel>()
            {
                new Imovel(){
                    Cep = "89107000",
                    Bairro = "Centro",
                    Logradouro = "Rua Pahoca",
                    Municipio = "Pomerode",
                    Numero = "55",
                    Complemento = "Casa",
                    ProprietarioId = context.Proprietarios
                                            .FirstOrDefault(x => x.Nome == "Estefani").Id
                },
                new Imovel(){
                    Cep = "89107000",
                    Bairro = "Centro",
                    Logradouro = "Rua Pahoca",
                    Municipio = "Pomerode",
                    Numero = "55",
                    Complemento = "Casa",
                    ProprietarioId = context.Proprietarios
                                            .FirstOrDefault(x => x.Nome == "Elia").Id
                },
            };

            listaImoveis.ForEach(s =>
                context.Imoveis.AddOrUpdate(x => new { x.ProprietarioId, x.Cep }, s)
            );

            context.SaveChanges();
        }
    }
}
