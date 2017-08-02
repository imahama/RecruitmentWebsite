using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecruitmentWebsite.Models
{
    public class YourDetailsViewModel: BaseRegistrationViewModel
    {
        [DisplayName("Contact ID")]
        public int ContactID { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Surname")]
        public string Surname { get; set; }
    }
}