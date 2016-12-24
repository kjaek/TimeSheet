using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheet.Data.Infrastructure;
using TimeSheet.Model;

namespace TimeSheet.Data.Repositories
{
    public class ProjectRepository : RepositoryBase<Project>, IProjectRepository
    {
        public ProjectRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        //public Project GetProjectByDescription(string description)
        //{
        //    var project = this.DbContext.Projects.Where(p => p.Description == description).FirstOrDefault();

        //    return project;
        //}

        //public override void Update(Project entity)
        //{
        //    base.Update(entity);
        //}
    }

    public interface IProjectRepository : IRepository<Project>
    {
        //Project GetProjectByDescription(string description);
    }
}
