using System;
using System.Collections.Generic;

namespace HealthApp.Data
{
    public class Person
    {
        public Person()
        {
            Readings = new List<Reading>();
        }

        public int person_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime dob { get; set; }
        public int height { get; set; }
        

        public virtual ICollection<Reading> Readings { get; set; }
    }
}