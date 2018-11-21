using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace T1708M1New.Controllers
{
    public class Student
    {

        [Key]
        [Display(Name = "RollNumber")]
        public string RollNumber { get; set; }
        [Display(Name = "FirsName")]

        public string FirsName { get; set; }

        //public static explicit operator Student(object )
        //{
        //    throw new NotImplementedException();
        //}

        [Display(Name = "FullName")] 
        public string FullName { get; set; }
        [Display(Name = "LastName")]

        public string Lastname { get; set; }
        [Display(Name = "Email")]

        public string Email { get; set; }
        [Display(Name = "Phone")]

        public string Phone { get; set; }
        [Display(Name = "Birthaday")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime Birthday { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Gender")]
        public Gender Gender { get; set; }

        [Display(Name = "Create At")]
        public DateTime CreateAt { get; set; }
        [Display(Name = "UpdateAt")]
        public DateTime UpdateAt { get; set; }
        [Display(Name = "Student Status")]
        public StudentStatus Status { get; set; }
        public Student()
        {
            this.CreateAt = DateTime.Now;
            this.UpdateAt = DateTime.Now;
            this.Gender = Gender.Male;
            this.Status = StudentStatus.Activated;



    

    }
}

    public enum StudentStatus
    {
        Activated = 1,
        Deactivated = 0
    }
    public enum Gender
    {
        Male = 1,
        Female = 0,
        Orther = 2
    }
    public class HangAttribute : ValidationAttribute, IClientModelValidator
    {
        public string _LyCuongFirstName;

        public string MessageError { get; set; }
        public HangAttribute(string lycuongFirstName)
        {
            _LyCuongFirstName = lycuongFirstName;
        }
        public void AddValidation(ClientModelValidationContext context)

        {
            if (context == null)
            {


                throw new NotImplementedException(nameof(context));
            }
            context.Attributes["data-val"] = "true";
            context.Attributes["data-val-cuong"] = "MessageError";
            context.Attributes["data-val-cuong-lycuongFirstName"] = _LyCuongFirstName;
            }

      
    }
    
    
    
}

