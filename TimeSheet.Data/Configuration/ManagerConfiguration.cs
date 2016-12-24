using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using TimeSheet.Model;

namespace TimeSheet.Data.Configuration
{
    public class ManagerConfiguration : EntityTypeConfiguration<Manager>
    {
        public ManagerConfiguration()
        {
            ToTable("Manager");
            Property(m => m.FirstName).IsRequired().HasMaxLength(20);
            Property(m => m.Surname).IsRequired().HasMaxLength(20);
            Property(m => m.Email).IsRequired();
        }
    }
}
