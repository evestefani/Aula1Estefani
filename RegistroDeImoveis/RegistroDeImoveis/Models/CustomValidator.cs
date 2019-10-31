using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistroDeImoveis.Models
{
    public class CustomValidator : ValidationAttribute
    {
        RegistroDeImoveisContext db = new RegistroDeImoveisContext();

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (validationContext.DisplayName == "Nome")
            {
                if (db.Proprietarios
                    .FirstOrDefault(x => x.Nome == value.ToString()) != null)
                    return new ValidationResult("Este usuário já existe");

                if (value.ToString().Contains("Estefani"))
                    return new ValidationResult("Não é possivel registar esse nome em nossa base de dados porque ele é unico.");
            }

            if (validationContext.DisplayName == "Email")
            {
                if (db.Proprietarios
                    .FirstOrDefault(x => x.Email == value.ToString()) != null)
                    return new ValidationResult("Este email já existe");

                if (value.ToString().Contains("Estefani"))
                    return new ValidationResult("Não é possivel registar esse email em nossa base de dados porque ele é unico.");
            }

            if (validationContext.DisplayName == "DataDeNascimento")
            {

                var dataInformada = DateTime.Parse(value.ToString());
                var idade = DateTime.Now.Year - dataInformada.Year;

                if (idade < 18)
                    return new ValidationResult("É preciso ser maior de 18 anos para efetuar o cadastro!");

                if (idade > 150)
                    return new ValidationResult("Idade apresentada é maior que o permitido!");

            }

            return ValidationResult.Success;
        }
    }
}
