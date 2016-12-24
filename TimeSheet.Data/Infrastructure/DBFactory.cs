using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheet.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        TimeSheetEntities dbContext;

        public TimeSheetEntities Init()
        {
            return dbContext ?? (dbContext = new TimeSheetEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
