using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheet.Data.Infrastructure;
using TimeSheet.Model;

namespace TimeSheet.Data.Repositories
{
    public class ManagerRepository : RepositoryBase<Manager>, IManagerRepository
    {
        public ManagerRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IManagerRepository : IRepository<Manager> { }
}
