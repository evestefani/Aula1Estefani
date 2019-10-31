using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistroDeImoveis.Models
{
    public class CustomValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            RegistroDeImoveisContext db = new RegistroDeImoveisContext();

            if (db.Proprietarios.FirstOrDefault(x => x.Nome == value.ToString()) != null)
                return new ValidationResult("Usuário já cadastrado");
            //throw new Exception("Usuário já existe na nossa base de dados");

            return ValidationResult.Success;
        }
    }
}