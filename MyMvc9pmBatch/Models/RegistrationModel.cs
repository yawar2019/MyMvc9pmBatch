using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMvc9pmBatch.Models
{
    public class RegistrationModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Dob { get; set; }
        public string EmailId { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public bool IsAgreementAccepted { get; set; }


    }
}