using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMvc9pmBatch.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "UserName Cannot be Empty")]
        public string UserName { get; set; }
        public string Password { get; set; }
         
        [Compare("Password", ErrorMessage = "Password and ConfirmPassword Mismatch")]
        public string ConfirmPassword { get; set; }
        [DataType(DataType.DateTime)]
        [RegularExpression("^[A-Za-z]*$", ErrorMessage ="only characters Allowed")]
        public string Dob { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid EmailId")]//.@
        public string EmailId { get; set; }
        [Required]
        public string Country { get; set; }
        [Range(12, 40, ErrorMessage = "Age was not b/w 12-40")]
        public int Age { get; set; }
        [StringLength(1,ErrorMessage ="You Can Write M or F")]
        public string Gender { get; set; }
        public bool IsAgreementAccepted { get; set; }


    }
}