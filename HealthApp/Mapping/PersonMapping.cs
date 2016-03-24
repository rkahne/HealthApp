using HealthApp.Data;
using System.Data.Entity.ModelConfiguration;

namespace HealthApp.Mapping
{
    public class PersonMapping : EntityTypeConfiguration<Person>
    {
        public PersonMapping()
        {
            HasKey(m => m.person_id);
            Property(m => m.first_name).IsRequired();
            Property(m => m.last_name).IsRequired();
            Property(m => m.dob).IsRequired();
            Property(m => m.height).IsRequired();

            // Property(m => m.something).IsRequired() or .IsOptional();
        }
    }
}