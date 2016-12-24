using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using TimeSheet.Model;

namespace TimeSheet.Data.Configuration
{
    public class StaffConfiguration : EntityTypeConfiguration<Staff>
    {
        public StaffConfiguration()
        {
            ToTable("Staff");
            Property(s => s.FirstName).IsRequired().HasMaxLength(20);
            Property(s => s.Surname).IsRequired().HasMaxLength(20);
            Property(s => s.Username).IsRequired().HasMaxLength(20);
            Property(s => s.Email).IsRequired();
            Property(s => s.ChargeRate).HasPrecision(8, 2);
            Property(s => s.CostRate).HasPrecision(8, 2);
            Property(s => s.Notes);
        }
    }
}
