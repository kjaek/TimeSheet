using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheet.Model;
using TimeSheet.Data.Configuration;
using System.Data.Entity;

namespace TimeSheet.Data
{
    public class TimeSheetEntities : DbContext
    {
        public TimeSheetEntities() : base("TimeSheetEntities") { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }
        
        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProjectConfiguration());
            modelBuilder.Configurations.Add(new ProjectTaskConfiguration());
        }
    }
}
