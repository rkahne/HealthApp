using System;
using System.ComponentModel.DataAnnotations;

namespace HealthApp.Models
{
        public class PersonCreateViewModel
        {

            [Required]
            [Display(Name = "First Name")]
            public string first_name { get; set; }

            [Required]
            [Display(Name = "Last Name")]
            public string last_name { get; set; }
            
            [Required]
            [Display(Name = "Date of Birth")]
            public DateTime dob { get; set; }

            [Required]
            [Display(Name = "Height (inches)")]
            public int height { get; set; }
            
            
        }
}