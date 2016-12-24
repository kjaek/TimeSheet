using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using TimeSheet.Model;

namespace TimeSheet.Data.Configuration
{
    public class StaffProjectConfiguration : EntityTypeConfiguration<StaffProject>
    {
        public StaffProjectConfiguration()
        {
            ToTable("StaffProject");
            Property(sp => sp.Role).HasMaxLength(10);
            Property(sp => sp.ChargeRate).HasPrecision(8, 2);
            Property(sp => sp.CostRate).HasPrecision(8, 2);
        }
    }
}
