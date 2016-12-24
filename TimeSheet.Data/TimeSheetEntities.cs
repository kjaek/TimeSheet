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
        public DbSet<Staff> Staff { get; set; }
        public DbSet<StaffProject> StaffProjects { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        
        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProjectConfiguration());
            modelBuilder.Configurations.Add(new ProjectTaskConfiguration());
            modelBuilder.Configurations.Add(new StaffConfiguration());
            modelBuilder.Configurations.Add(new StaffProjectConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new ManagerConfiguration());
            modelBuilder.Configurations.Add(new SupplierConfiguration());
        }
    }
}
