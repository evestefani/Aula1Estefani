using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioRegistroImoveisCore.Model
{

    public class CustomValidator : ValidationAttribute
    {
        WebApiContext db = new WebApiContext();

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

            
            return ValidationResult.Success;
        }
    }
}
