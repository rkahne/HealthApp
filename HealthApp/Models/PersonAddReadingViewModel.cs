using HealthApp.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace HealthApp.Models
{
    public class PersonAddReadingViewModel
    {
        [Required]
        [Display(Name = "Person")]
        public int person_id { get; set; }

        [Required]
        [Display(Name = "Date of Reading")]
        public DateTime reading_date { get; set; }

        [Display(Name = "Weight (lbs)")]
        public int weight { get; set; }

        [Display(Name = "Total Cholesterol")]
        public int tc { get; set; }

        [Display(Name = "LDL Cholesterol")]
        public int ldl { get; set; }

        [Display(Name = "HDL Cholesterol")]
        public int hdl { get; set; }

        [Display(Name = "Triglycerides")]
        public int triglycerides { get; set; }

        [Display(Name = "Glucose")]
        public int glucose { get; set; }

        [Display(Name = "Systolic Blood Pressure")]
        public int sbp { get; set; }

        [Display(Name = "Diastolic Blood Pressure")]
        public int dbp { get; set; }


    }
}