using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using T1708M1New.Controllers;

namespace T1708M1New.Models
{
    public class CheckEmail : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Student st =(Student)validationContext.ObjectInstance;
            string email = value as string;
            if(st.Email.Contains("SSSSSSs"))
            {
                return new ValidationResult("can't you aa", new[] { "Email" });
            }
            return ValidationResult.Success;
            
        }
    }
}
