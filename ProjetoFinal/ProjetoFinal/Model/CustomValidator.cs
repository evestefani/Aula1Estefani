using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Model
{
    public class CustomValidator : ValidationAttribute
    {
        ProjetoFinalContext db = new ProjetoFinalContext();

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (validationContext.DisplayName == "Nome")
            {
                if (db.Usuarios
                    .FirstOrDefault(x => x.Nome == value.ToString()) != null)
                    return new ValidationResult("Nome já existente!");
            }

            if (validationContext.DisplayName == "Login")
            {
                if (db.Usuarios
                    .FirstOrDefault(x => x.Login == value.ToString()) != null)
                    return new ValidationResult("Login já existente!");
            }

            if (validationContext.DisplayName == "Senha")
            {
                if (db.Usuarios
                    .FirstOrDefault(x => x.Senha == value.ToString()) != null)
                    return new ValidationResult("Senha já existente!");
            }

            if (validationContext.DisplayName == "Email")
            {
                if (db.Usuarios
                    .FirstOrDefault(x => x.Email == value.ToString()) != null)
                    return new ValidationResult("Email já existente!");
            }

            return ValidationResult.Success;
        }
    }
}
