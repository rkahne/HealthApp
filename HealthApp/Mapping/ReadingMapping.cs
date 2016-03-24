using HealthApp.Data;
using System;
using System.Collections.Generic;
using HealthApp.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;


namespace HealthApp.Mapping
{
    public class ReadingMapping : EntityTypeConfiguration<Reading>
    {
        public ReadingMapping()
        {
            HasKey(m => m.reading_id);
            Property(m => m.reading_date).IsRequired();
            Property(m => m.weight).IsOptional();
            Property(m => m.sbp).IsOptional();
            Property(m => m.dbp).IsOptional();
            Property(m => m.tc).IsOptional();
            Property(m => m.triglycerides).IsOptional();
            Property(m => m.hdl).IsOptional();
            Property(m => m.ldl).IsOptional();
            Property(m => m.glucose).IsOptional();


            // Property(m => m.something).IsRequired() or .IsOptional();
        }
    }
}