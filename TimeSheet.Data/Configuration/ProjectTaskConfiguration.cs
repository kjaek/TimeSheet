using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using TimeSheet.Model;

namespace TimeSheet.Data.Configuration
{
    public class ProjectTaskConfiguration : EntityTypeConfiguration<ProjectTask>
    {
        public ProjectTaskConfiguration()
        {
            ToTable("ProjectTask");
            Property(g => g.Description).IsRequired().HasMaxLength(50);
            Property(g => g.BudgetAmount).IsRequired().HasPrecision(8, 2);
            Property(g => g.BudgetHours).IsRequired().HasPrecision(8, 2);
            Property(g => g.Chargeable).IsRequired();
            Property(g => g.Notes).HasMaxLength(200);
        }
    }
}
