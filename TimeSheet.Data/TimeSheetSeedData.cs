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
            GetProjectTasks().ForEach(t => context.ProjectTasks.Add(t));

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
    }
}
