using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecruitmentWebsite.Models
{
    public class RegistrationViewModel
    {
        public List<string> _ActionNameList = new List<string>();
        public int StepIndex { get; set; } = 0;

        //public YourDetailsViewModel YourDetails { get; set; }
        //public DemogsViewModel Demogs { get; set; }
    }
}