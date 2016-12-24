using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using TimeSheet.Model;

namespace TimeSheet.Data.Configuration
{
    public class ProjectConfiguration : EntityTypeConfiguration<Project>
    {
        public ProjectConfiguration()
        {
            ToTable("Projects");
            Property(p => p.Code).IsRequired().HasMaxLength(10);
            Property(p => p.Description).IsRequired().HasMaxLength(50);
            Property(p => p.BudgetAmount).HasPrecision(8,2);
            Property(p => p.Chargeable);
            Property(p => p.Notes).HasMaxLength(200);
            Property(p => p.ProjectID).IsRequired();
        }
    }
}
