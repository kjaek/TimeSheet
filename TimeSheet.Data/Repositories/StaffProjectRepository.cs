using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheet.Data.Infrastructure;
using TimeSheet.Model;

namespace TimeSheet.Data.Repositories
{
    public class StaffProjectRepository : RepositoryBase<StaffProject>, IStaffProjectRepository
    {
        public StaffProjectRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IStaffProjectRepository : IRepository<StaffProject> { }
}
