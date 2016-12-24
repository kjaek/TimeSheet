using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheet.Model;
using System.Data.Entity;

namespace TimeSheet.Data
{
    public class TimeSheetSeedData : DropCreateDatabaseAlways<TimeSheetEntities>
    {
        protected override void Seed(TimeSheetEntities context)
        {
            GetStaff().ForEach(s => context.Staff.Add(s));
            GetProjects().ForEach(p => context.Projects.Add(p));
            GetStaffProjects().ForEach(sp => context.StaffProjects.Add(sp));
            GetProjectTasks().ForEach(t => context.ProjectTasks.Add(t));
            GetCustomers().ForEach(c => context.Customers.Add(c));
            GetManagers().ForEach(m => context.Managers.Add(m));
            GetSuppliers().ForEach(s => context.Suppliers.Add(s));

            context.Commit();
        }

        protected static List<Staff> GetStaff()
        {
            return new List<Staff>
            {
                new Staff()
                {
                    FirstName = "Adam",
                    Surname = "Johnson",
                    Username = "adamj",
                    Email = "adamj@abcservices.comm",
                    ChargeRate = 110,
                    CostRate = 70,
                },
                new Staff()
                {
                    FirstName = "Dave",
                    Surname = "Clarke",
                    Username = "davec",
                    Email = "davec@abcservices.comm",
                    ChargeRate = 90,
                    CostRate = 55,
                },
                new Staff()
                {
                    FirstName = "Dave",
                    Surname = "Smith",
                    Username = "dave",
                    Email = "dave@abcservices.comm",
                    ChargeRate = 150,
                    CostRate = (decimal)64.17,
                },
                new Staff()
                {
                    FirstName = "Jamie",
                    Surname = "Davidson",
                    Username = "jamied",
                    Email = "jamied@abcservices.comm",
                    ChargeRate = 110,
                    CostRate = 70,
                },
                new Staff()
                {
                    FirstName = "Jeff",
                    Surname = "Mills",
                    Username = "jeffm",
                    Email = "jeffm@abcservices.comm",
                    ChargeRate = 110,
                    CostRate = 70,
                },
            };
        }

        protected static List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project()
                {
                    ProjectID = 1,
                    Code = "ICTIM",
                    Description = "ABC Services - General Office",
                    BudgetAmount = 0,
                    Chargeable = false,
                    Notes = "When the Time Clock interface is used, Time Clock Staff will be recording their time against this Project",
                },
                new Project()
                {
                    ProjectID = 2,
                    Code = "AHD",
                    Description = "Adaptec - Help Desk Services",
                    BudgetAmount = 120000,
                    Chargeable = true,
                },
                new Project()
                {
                    ProjectID = 3,
                    Code = "CMD",
                    Description = "Citrus - Multimedia Presentation Development",
                    BudgetAmount = 250000,
                    Chargeable = true,
                },
                new Project()
                {
                    ProjectID = 4,
                    Code = "ICADM",
                    Description = "ABC Services - Internal Administration",
                    BudgetAmount = 15000,
                    Chargeable = true,
                    Notes = "When the Time Clock interface is used, Time Clock Staff will be recording their time against this Project",
                },
            };
        }

        protected static List<StaffProject> GetStaffProjects()
        {
            return new List<StaffProject>
            {
                new StaffProject()
                {
                    ChargeRate = 110,
                    CostRate = 70,
                },
            };
        }

        protected static List<ProjectTask> GetProjectTasks()
        {
            return new List<ProjectTask>
            {
                new ProjectTask()
                {
                    ProjectID = 2,
                    Description = "Change Requests",
                    BudgetAmount = 5000,
                    BudgetHours = 50,
                    Chargeable = true
                },
                new ProjectTask()
                {
                    ProjectID = 2,
                    Description = "Documentation",
                    BudgetAmount = 4000,
                    BudgetHours = 40,
                    Chargeable = true
                },
                new ProjectTask()
                {
                    ProjectID = 2,
                    Description = "Front Line Support",
                    BudgetAmount = 15000,
                    BudgetHours = 150,
                    Chargeable = true
                },
                new ProjectTask()
                {
                    ProjectID = 2,
                    Description = "Procurement",
                    BudgetAmount = 20000,
                    BudgetHours = 200,
                    Chargeable = true
                },
                new ProjectTask()
                {
                    ProjectID = 3,
                    Description = "Change Management",
                    BudgetAmount = 4000,
                    BudgetHours = 40,
                    Chargeable = true
                },
                new ProjectTask()
                {
                    ProjectID = 3,
                    Description = "Construction",
                    BudgetAmount = 50000,
                    BudgetHours = 500,
                    Chargeable = true
                },
                new ProjectTask()
                {
                    ProjectID = 3,
                    Description = "Deployment",
                    BudgetAmount = 4000,
                    BudgetHours = 40,
                    Chargeable = true
                },
            };
        }

        protected static List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer()
                {
                    Code = "ABC",
                    Name = "ABC Services (Internal)",
                    Notes = "Internal company"
                },
                new Customer()
                {
                    Code = "AS",
                    Name = "Adaptec",
                    Notes = ""
                },
                new Customer()
                {
                    Code = "CC",
                    Name = "Citrus Corporation",
                    Notes = ""
                },
                new Customer()
                {
                    Code = "ES",
                    Name = "e-Global Corporation",
                    Notes = ""
                },
            };
        }

        protected static List<Manager> GetManagers()
        {
            return new List<Manager>
            {
                new Manager()
                {
                    FirstName = "Eric",
                    Surname = "Johnson",
                    Email = "eric.johnson@abcservices.com"
                },
                new Manager()
                {
                    FirstName = "Steven",
                    Surname = "Black",
                    Email = "steven.black@abcservices.com"
                },
            };
        }

        protected static List<Supplier> GetSuppliers()
        {
            return new List<Supplier>
            {
                new Supplier()
                {
                    Code = "AO",
                    Name = "Active-8 Organisation",
                },
                new Supplier()
                {
                    Code = "EMA",
                    Name = "Emacon",
                },
                new Supplier()
                {
                    Code = "EON",
                    Name = "Eon Services",
                },
                new Supplier()
                {
                    Code = "JET",
                    Name = "JetNet",
                },
            };
        }
    }
}
