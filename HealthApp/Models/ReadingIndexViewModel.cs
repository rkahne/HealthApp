using HealthApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthApp.Models
{
    public class ReadingIndexViewModel
    {
        [Required]
        public DateTime reading_date { get; set; }

        public float bmi { get; set; }
        public int weight { get; set; }
        public int tc { get; set; }
        public int ldl { get; set; }
        public int hdl { get; set; }
        public int triglycerides { get; set; }
        public int glucose { get; set; }
        public int sbp { get; set; }
        public int dbp { get; set; }
    }
}