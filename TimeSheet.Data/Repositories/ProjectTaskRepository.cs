using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheet.Data.Infrastructure;
using TimeSheet.Model;

namespace TimeSheet.Data.Repositories
{
    public class ProjectTaskRepository : RepositoryBase<ProjectTask>, IProjectTaskRepository
    {
        public ProjectTaskRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IProjectTaskRepository : IRepository<ProjectTask> { }
}
