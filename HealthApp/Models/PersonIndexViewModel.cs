using System;

namespace HealthApp.Models
{
    public class PersonIndexViewModel
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime dob { get; set; }
        public int height { get; set; }

        // public int bmi => (weight / (height* height)) * 703;
    }
  
}