using System;

namespace HealthApp.Data
{
    public class Reading
    {
        public int reading_id { get; set; } // primary key
        public DateTime reading_date { get; set; }
        public int weight { get; set; }
        public int ldl { get; set; }
        public int hdl { get; set; }
        public int tc { get; set; }
        public int triglycerides { get; set; }
        public int glucose { get; set; }
        public int sbp { get; set; }
        public int dbp { get; set; }

        public virtual Person Person { get; set; }
    }
}