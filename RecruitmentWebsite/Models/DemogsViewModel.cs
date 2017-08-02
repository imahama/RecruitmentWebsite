using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecruitmentWebsite.Models
{
    public class DemogsViewModel: BaseRegistrationViewModel
    {
        [DisplayName("Question ID")]
        public int QuestionID { get; set; }
        [DisplayName("Question Name")]
        public string QuestionName { get; set; }
        [DisplayName("Question Desc")]
        public string QuestionDesc { get; set; }
    }
}